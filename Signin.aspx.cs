using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signin : System.Web.UI.Page
{
    UsersDataAccessLayer objUsersDataAccessLayer = new UsersDataAccessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["r"] == "dc")
        {
            msg1.Visible = true;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel1();", true);
        }
        else if (Request.QueryString["r"] == "pc")
        {
            msg2.Visible = true;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel2();", true);
        }
        else if (Request.QueryString["r"] == "de")
        {
            msg3.Visible = true;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel3();", true);
        }
        else if (Request.QueryString["r"] == "pe")
        {
            msg4.Visible = true;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel4();", true);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = "", password = "";
        username = TextBox_Username.Text;
        password = TextBox_Password.Text;
        string temp = null;
        for (int i = 0; i < username.Length; i++)
        {
            if (username[i] == '\'')
                temp += "`";
            else if (username[i] == '\"')
                temp += "``";
            else
                temp += username[i];
        }
        username = temp;
        temp = "";
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] == '\'')
                temp += "`";
            else if (password[i] == '\"')
                temp += "``";
            else
                temp += password[i];
        }
        password = temp;

        Users user = objUsersDataAccessLayer.Signin(username, password);

        if (user != null)
        {
            Response.Cookies["username"].Value = user.Username;
            Response.Cookies["role"].Value = user.Role;

            if(user.Role == "Admin")
                Response.Redirect("admin_panel/Default.aspx");
            else if (user.Role == "Doctor")
                Response.Redirect("Doctor/Default.aspx");
            else if (user.Role == "Patient")
                Response.Redirect("Patient/Default.aspx");
        }
        else
            Response.Write("<script>alert('Invalid Username OR Password')</script>");
    }
}