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
    public partial class aplicarf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
            string requs = "";
            for (int i = 0; i < chkModuleList.Items.Count; i++)
            {
                if (chkModuleList.Items[i].Selected)
                {
                    requs = requs + chkModuleList.Items[i].Text + ", ";


                    var itemValue = chkModuleList.Items[i].Value;
                }
            }
            requs = requs + "o.";
            string ced = cedu.Text;
            string nom = nombre.Text;
            string ape = apellidos.Text;
            string cor = correo.Text;
            string stado = "aplicante";
            //insert
           /* string constr = ConfigurationManager.ConnectionStrings["emailConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string query = "INSERT into aplicantes (cedula, nombre, apellidos, requerimientos,correo,estado) VALUES (" + int.Parse(ced) + ", '" + nom + "', '" + ape + "', '" + requs.ToString() + "', '" + cor + "', '" + stado + "')";
            SqlCommand cum = new SqlCommand(query, con);
            con.Open();
            cum.ExecuteNonQuery();

            con.Close();
            //fin insert
            //inicio email*/
           try
           {
               MailMessage mail = new MailMessage();
               SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

               mail.From = new MailAddress("andresduran1710@gmail.com");
               mail.To.Add(cor);
               mail.Subject = "Proceso de registro Para FREIDOSS";
               mail.Body = "Hola, " + nom + ", sus datos han sido ingresados al sistema \n Muchas gracias por aplicar para trabajar con nosotros.";

               SmtpServer.Port = 587;
               SmtpServer.Credentials = new System.Net.NetworkCredential("andresduran1710@gmail.com", "sannin10");
               SmtpServer.EnableSsl = true;

               SmtpServer.Send(mail);
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.ToString());
           }//fin email

           testf.Text = "Datos ingresados correctamente!";


        }

    }
}