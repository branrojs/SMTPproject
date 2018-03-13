using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;

namespace WebApplication1.Account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string constr = ConfigurationManager.ConnectionStrings["emailConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        static SqlDataReader dr;
        SqlCommand cmd;

        protected void pp_Click(object sender, EventArgs e)
        {
             con.Open();
            cmd = new SqlCommand("Select * from aplicantes where estado='aplicante'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            cedu.Text=dr[0].ToString();
            nombre.Text = dr[1].ToString();
            apellidos.Text = dr[2].ToString();
            string rq = dr[3].ToString();
            string [] lavarq = rq.Split(',');
            requiobt.Text = "";
            for (int i = 0; i < lavarq.Length ; i++)
            {
                requiobt.Text = requiobt.Text + lavarq[i].ToString() + Environment.NewLine;  
            }
            correo.Text = dr[4].ToString();
            nomas.Text = "";
            next.Visible = true;
            enviarm.Visible = true;

        }

        protected void next_Click(object sender, EventArgs e)
        {
            if (dr.Read())
            {
                cedu.Text = dr[0].ToString();
                nombre.Text = dr[1].ToString();
                apellidos.Text = dr[2].ToString();
                string rq = dr[3].ToString();
                string[] lavarq = rq.Split(',');
                requiobt.Text = "";
                for (int i = 0; i < lavarq.Length; i++)
                {
                    requiobt.Text = requiobt.Text + lavarq[i].ToString() + Environment.NewLine;
                }
                correo.Text = dr[4].ToString();

                next.Visible = true;
                enviarm.Visible = true;
            }
            else
            {
                nomas.Text = "No hay mas aplicantes en la base de datos";
            }
            next.Visible = true;
            enviarm.Visible = true;
        }

        protected void enviarm_Click(object sender, EventArgs e)
        {
            //inicio email
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("andresduran1710@gmail.com");
                mail.To.Add(correo.Text);
                mail.Subject = "Elegido para entrevista al puesto de Freidor";
                mail.Body = "Hola, " + nombre.Text + ", sus datos han sido evaluados y nos interesaria entrevistarte, por ello te hacemos la invitacion a entrevista, lo unico que debes hacer es responder a este correo con el titulo 'Enterado e interesado'.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("andresduran1710@gmail.com", "sannin10");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }//fin email
            //update del cliente
            string constr2 = ConfigurationManager.ConnectionStrings["emailConnectionString"].ConnectionString;
            SqlConnection con2 = new SqlConnection(constr);
            string query = "Update aplicantes Set estado='informado' where cedula="+int.Parse(cedu.Text)+";";
            con2.Open();
            SqlCommand cmd2=new SqlCommand(query,con2);
            cmd2.ExecuteNonQuery();
            con2.Close();
        }
    }
}