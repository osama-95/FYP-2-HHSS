using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignupDoctor : System.Web.UI.Page
{
    DoctorsDataAccessLayer objDoctorsDataAccessLayer = new DoctorsDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox_Password.Text == TextBox_CPassword.Text)
        {
            Users user = new Users();
            Doctors doctor = new Doctors();

            user.Username = TextBox_Username.Text;
            user.Password = TextBox_Password.Text;
            user.Role = "Doctor";

            doctor.User = user;
            doctor.TibbId = TextBox_TibbId.Text;
            doctor.FName = TextBox_FName.Text;
            doctor.LName = TextBox_LName.Text;
            doctor.AvailabilityTimeFrom = TextBox_AvailabilityTimeFrom.Text;
            doctor.AvailabilityTimeTo = TextBox_AvailabilityTimeTo.Text;
            doctor.AvailabilityDays = TextBox_AvailabilityDays.Text;
            doctor.Specialty = TextBox_Specialty.Text;
            doctor.Experience = TextBox_Experience.Text;
            doctor.Contact = TextBox_Contact.Text;
            doctor.Email = TextBox_Email.Text;
            doctor.Address = TextBox_Address.Text;
            doctor.DateOfBirth = TextBox_DateOfBirth.Text;
            if (FileUpload1.HasFile)
            {
                Bitmap bmp1 = new Bitmap(FileUpload1.FileContent);
                MemoryStream stream = new MemoryStream();
                bmp1.Save(stream, bmp1.RawFormat);
                byte[] imageBytes = stream.ToArray();
                stream.Dispose();
                bmp1.Dispose();
                doctor.Image = imageBytes;
            }

            string resp = objDoctorsDataAccessLayer.Create(doctor);
            if (resp == "Doctor Created")
                Response.Redirect("Signin.aspx?r=dc");
            else if (resp == "User Already Exist")
            {
                msg3.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "HideLabel3();", true);
            }
        }
        else
        Response.Write("<script>alert('Password not matched.')</script>");
    }
}