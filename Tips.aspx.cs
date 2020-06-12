using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tips : System.Web.UI.Page
{
    DoctorTipsDataAccessLayer objDoctorTipsDataAccessLayer = new DoctorTipsDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!this.IsPostBack)
        {
            BindDataTable();
        }
    }
    public void BindDataTable()
    {
        List<DoctorTips> listDoctorTips = new List<DoctorTips>();
        listDoctorTips = objDoctorTipsDataAccessLayer.GetAllDoctorTips();

        String UnreadText = "";
        Int32 i = 1;
        foreach (DoctorTips DoctorTip in listDoctorTips)
        {
            UnreadText += "<div class=\"col-md-6 pro-1\">";
            UnreadText += "<div class=\"col-m\" style=\"height:400px;\">";
            UnreadText += "<div class=\"women\"><a href = \"Herbs.aspx?id=" + DoctorTip.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></a></div>";
            UnreadText += "<div class=\"mid-2\">";
            UnreadText += "<p>" + DoctorTip.Description + "</p>";
            UnreadText += "<div class=\"block\"></div>";
            UnreadText += "<div class=\"clearfix\"></div>";
            UnreadText += "</div></div></div>";
            ProductDiv1.InnerHtml = UnreadText;
            i++;
        }
    }

}