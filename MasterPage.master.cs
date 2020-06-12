using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        String activepage = Request.RawUrl;

        if (activepage.Contains("SignupDoctor.aspx") || activepage.Contains("Signup.aspx") || activepage.Contains("Signin.aspx"))
        {
            HeaderImage.Visible = true;
        }

        if (activepage.Contains("Default.aspx"))
        {
            Home.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("DoctorsList.aspx"))
        {
            Doctors.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("HerbsList.aspx"))
        {
            Herbs.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("PrescriptionsList.aspx"))
        {
            Prescriptions.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("TipsList.aspx"))
        {
            Tips.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("Contactus.aspx"))
        {
            Contactus.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("") && !activepage.Contains("SignIn.aspx") && !activepage.Contains("Signin.aspx") && !activepage.Contains("Signup.aspx") && !activepage.Contains("SignUp.aspx") && !activepage.Contains("SignupDoctor.aspx") && !activepage.Contains("Signupdoctor.aspx"))
        {
            Home.Attributes.Add("class", "active");
        }
        Label_Year.Text = DateTime.Now.Year.ToString();
    }
    //protected void submit_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Result.aspx?id=" + TextBox_Disease.Text);
    //}
}
