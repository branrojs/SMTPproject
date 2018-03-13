using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogIn(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["emailConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);

            string pass = "select count(*) from usuariosrh where nombre = '"+UserName.Text+"' and password = '"+Password.Text+"'";
            SqlDataReader dr;
            con.Open();
            SqlCommand cum = new SqlCommand(pass, con);
            dr = cum.ExecuteReader();
            dr.Read();
            if (int.Parse(dr[0].ToString())==0)
            {
                FailureText.Text = "Invalid username or password.";
                ErrorMessage.Visible = true;
            }
            else if (int.Parse(dr[0].ToString()) == 1)
            {
                Response.Redirect("veraplicantes.aspx");
            }
            

            con.Close();



            
        }
    }
}

