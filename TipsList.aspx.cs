using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TipsList : System.Web.UI.Page
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

        String UnreadText = "", UnreadText1 = "";
        Int32 i = 1;
        if(listDoctorTips.Count > 0)
        {
            foreach (DoctorTips DoctorTip in listDoctorTips)
            {
                UnreadText += "<style>textarea{resize: none; overflow:hidden; border: none;text-align: justify; width:36em;} @media(max-width:414px){textarea{width:25em;}}</style>";
                UnreadText += "<div class=\"col-md-6 pro-6\">";
                UnreadText += "<div class=\"col-m\">";
                UnreadText += "<div class=\"women\"><a href = \"Herbs.aspx?id=" + DoctorTip.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></a></div>";
                UnreadText += "<div class=\"mid-2\">";
                UnreadText += "<textarea rows=\"4\">" + DoctorTip.Description + "</textarea>";
                UnreadText += "<div class=\"block\"></div>";
                UnreadText += "<div class=\"clearfix\"></div>";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModal" + i + "\" class=\"btn btn-danger my-cart-btn my-cart-b\" data-id=\"24\">View Details</a>";
                UnreadText += "</div></div><br /></div>";

                UnreadText1 += "<div class=\"modal fade\" id=\"myModal" + i + "\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\">";
                UnreadText1 += "<div class=\"modal-dialog\" role=\"document\">";
                UnreadText1 += "<div class=\"modal-content modal-info\">";
                UnreadText1 += "<div class=\"modal-header\">";
                UnreadText1 += "<button type = \"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"modal-body modal-spa\">";
                UnreadText1 += "<div class=\"col-md-12 span-1\">";
                UnreadText1 += "<div class=\"women\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></div>";
                UnreadText1 += "<p class=\"in-para\" style=\"font-size:20px;\">"+DoctorTip.Description+"</p>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";

                ProductDiv1.InnerHtml = UnreadText;
                ProductDiv2.InnerHtml = UnreadText1;
                i++;
            }
        }
        else
        {
            msg.Visible = true;
        }
    }

}