using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    PatientsDataAccessLayer objPatientsDataAccessLayer = new PatientsDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox_Password.Text == TextBox_CPassword.Text)
        {
            Users user = new Users();
            Patients Patient = new Patients();

            user.Username = TextBox_Username.Text;
            user.Password = TextBox_Password.Text;
            user.Role = "Patient";

            Patient.User = user;
            Patient.FName = TextBox_FName.Text;
            Patient.LName = TextBox_LName.Text;
            Patient.Contact = TextBox_Contact.Text;
            Patient.Email = TextBox_Email.Text;
            Patient.DateOfBirth = TextBox_DateOfBirth.Text;

            string resp = objPatientsDataAccessLayer.Create(Patient);
            if (resp == "Patient Created")
                Response.Redirect("Signin.aspx?r=pc");
            else if (resp == "User Already Exist")
            {
                msg4.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel4();", true);
            }
        }
        else
            Response.Write("<script>alert('Password not matched.')</script>");
    }
}