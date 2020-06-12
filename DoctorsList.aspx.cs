using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DoctorsList : System.Web.UI.Page
{
    DoctorsDataAccessLayer objDoctorsDataAccessLayer = new DoctorsDataAccessLayer();
    FeedbacksDataAccessLayer objFeedbacksDataAccessLayer = new FeedbacksDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindDataTable();
        }
    }
    public void BindDataTable()
    {
        List<Doctors> listDoctors = new List<Doctors>();

        listDoctors = objDoctorsDataAccessLayer.GetAllDoctors();
        String UnreadText = "", UnreadText1 = "";
        Int32 i = 1;
        if (listDoctors.Count > 0)
        {
            foreach (Doctors Doctor in listDoctors)
            {
                string strBase64 = null;
                if (Doctor.Image != null)
                {
                    strBase64 = Convert.ToBase64String(Doctor.Image);
                }
                UnreadText += "<div class=\"col-md-3 pro-1\">";
                UnreadText += "<div class=\"col-m\" style=\"height:300px;\">";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModal" + i + "\" class=\"offer-img\">";
                UnreadText += "<center><img alt=\"\" src=\"data:image/png;base64," + strBase64 + "\" width=\"120\" height=\"100\"/></center></td>";
                UnreadText += "</a>";
                UnreadText += "<div class=\"mid-1\">";
                UnreadText += "<div class=\"women\"><h6>Name: Dr. " + Doctor.FName + " "+Doctor.LName+"</h6></div>";
                UnreadText += "<div class=\"mid-2\">";
                UnreadText += "<p >Specialization: " + Doctor.Specialty + "</p>";
                UnreadText += "<div class=\"block\"></div>";
                UnreadText += "<div class=\"clearfix\"></div>";
                UnreadText += "</div>";
                UnreadText += "<div class=\"add\">";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModal" + i + "\" class=\"btn btn-danger my-cart-btn my-cart-b\" data-id=\"24\">View Avalability</a>";
                UnreadText += "</div></div></div></div>";

                UnreadText1 += "<div class=\"modal fade\" id=\"myModal" + i + "\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\">";
                UnreadText1 += "<div class=\"modal-dialog\" role=\"document\">";
                UnreadText1 += "<div class=\"modal-content modal-info\">";
                UnreadText1 += "<div class=\"modal-header\">";
                UnreadText1 += "<button type = \"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"modal-body modal-spa\">";
                UnreadText1 += "<div class=\"col-md-5 span-2\">";
                UnreadText1 += "<div class=\"item\"><center><img alt=\"\" src=\"data:image/png;base64," + strBase64 + "\" width=\"300\" height=\"300\" style=\"margin-top:20px; \"/></center></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"col-md-7 span-1\">";
                UnreadText1 += "<h3>Dr. " + Doctor.FName + " " + Doctor.LName + " ("+Doctor.TibbId+ ")</h3><p style=\"color:#029241; font-size:20px;\"><b>" + Doctor.Specialty + " Specialist</b></p>";
                //UnreadText1 += "<p class=\"in-para\" style=\"color:#029241;\"><b>" + Doctor.Specialty + " Specialist</b></p>";
                DateTime timeFrom, timeTo;
                timeFrom = DateTime.Parse(Doctor.AvailabilityTimeFrom);
                timeTo = DateTime.Parse(Doctor.AvailabilityTimeTo);
                UnreadText1 += "<p class=\"in-para\" style=\"font-size:20px;\"><b>Experience:</b> "+Doctor.Experience+"<br/><b>Availability Days:</b><br/> " + Doctor.AvailabilityDays+ "<br/><b>Availability Time:<br/></b> " + timeFrom.ToLongTimeString() + " To "+ timeTo.ToLongTimeString() + "</p>";
                UnreadText1 += " <div class=\"add-to\">";
                UnreadText1 += "<a class=\"btn btn-danger my-cart-btn my-cart-btn1 \" href=\"Patient/AppointmentRequest.aspx?id=" + Doctor.ID + "\">Get Appoinment</a>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"modal-body modal-spa\">";
                UnreadText1 += "<div class=\"col-md-12 span-1\">";
                UnreadText1 += "<h3>Patients Feedback</h3>";
                List<Feedbacks> FeedbacksList = new List<Feedbacks>();
                FeedbacksList = objFeedbacksDataAccessLayer.GetAllFeedbacksForDoctorByID(Doctor.ID.ToString());
                foreach (Feedbacks Feedback in FeedbacksList)
                {
                    UnreadText1 += "<p class=\"in-para\"><span class=\"reducedfrom \">"+Feedback.Patient.FName + " " + Feedback.Patient.LName + ":</span> "+Feedback.Comment+"</p>";
                }
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                ProductDiv.InnerHtml = UnreadText;
                ProductDiv1.InnerHtml = UnreadText1;
                i++;
            }
        }
        else
        {
            msg.Visible = true;
        }
    }
}