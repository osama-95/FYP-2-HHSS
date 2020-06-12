using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    HerbsDataAccessLayer objHerbsDataAccessLayer = new HerbsDataAccessLayer();
    DoctorPrescriptionsDataAccessLayer objDoctorPrescriptionsDataAccessLayer = new DoctorPrescriptionsDataAccessLayer();
    DoctorTipsDataAccessLayer objDoctorTipsDataAccessLayer = new DoctorTipsDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindDataTable();
            BindDataTable2();
            BindDataTable3();
        }
    }

    public void BindDataTable()
    {
        List<Herbs> listHerb = new List<Herbs>();

        listHerb = objHerbsDataAccessLayer.GetTop4Herbs();
        String UnreadText = "", UnreadText1 = "";
        Int32 i = 1;
        if (listHerb.Count > 0)
        {
            foreach (Herbs Herb in listHerb)
            {
                string strBase64 = null;
                if (Herb.Image != null)
                {
                    strBase64 = Convert.ToBase64String(Herb.Image);
                }
                UnreadText += "<div class=\"col-md-3 pro-1\">";
                UnreadText += "<div class=\"col-m\" style=\"height:300px;\">";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModal" + i + "\" class=\"offer-img\">";
                UnreadText += "<center><img alt=\"\" src=\"data:image/png;base64," + strBase64 + "\" width=\"120\" height=\"100\"/></center></td>";
                UnreadText += "</a>";
                UnreadText += "<div class=\"mid-1\">";
                UnreadText += "<div class=\"women\"><h6>" + Herb.Name + "</h6></div>";
                UnreadText += "<div class=\"mid-2\">";
                UnreadText += "<p ><em class=\"item_price\">Rs. " + Herb.Price + "</em></p>";
                UnreadText += "<div class=\"block\"></div>";
                UnreadText += "<div class=\"clearfix\"></div>";
                UnreadText += "</div>";
                UnreadText += "<div class=\"add\">";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModal" + i + "\" class=\"btn btn-danger my-cart-btn my-cart-b\" data-id=\"24\">View Details</a>";
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
                UnreadText1 += "<h3>" + Herb.Name + "</h3>";
                UnreadText1 += "<p class=\"in-para\">Vendor Contact #: " + Herb.VendorContact + "</p>";
                UnreadText1 += "<p class=\"in-para\">Vendor Email Address: " + Herb.VendorEmail + "</p>";
                UnreadText1 += "<div class=\"Fee_single\">";
                UnreadText1 += " <span class=\"reducedfrom\">Rs. " + Herb.Price + "</span>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "<h4 class=\"quick\">Quick Overview:</h4>";
                UnreadText1 += "<p class=\"quick_desc\">" + Herb.Description + "</p>";
                UnreadText1 += " <div class=\"add-to\">";
                UnreadText1 += "<a class=\"btn btn-danger my-cart-btn my-cart-btn1 \" data-dismiss=\"modal\" aria-label=\"Close\">Close</a>";
                UnreadText1 += "</div>";
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
            msg1.Visible = true;
        }
    }

    public void BindDataTable2()
    {
        List<DoctorPrescriptions> listDoctorPrescriptions = new List<DoctorPrescriptions>();
        listDoctorPrescriptions = objDoctorPrescriptionsDataAccessLayer.GetTop4DoctorPrescriptions();

        String UnreadText = "", UnreadText1 = "";
        Int32 i = 1;
        if (listDoctorPrescriptions.Count > 0)
        {
            foreach (DoctorPrescriptions DoctorPrescription in listDoctorPrescriptions)
            {
                //UnreadText += "<div class=\"col-md-6 pro-6\">";
                //UnreadText += "<div class=\"col-m\">";
                //UnreadText += "<div class=\"women\"><a href = \"HerbsList.aspx?id=" + DoctorPrescription.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorPrescription.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorPrescription.Doctor.FName + " " + DoctorPrescription.Doctor.LName + "(" + DoctorPrescription.Doctor.Specialty + " Specialist)</h4></center></a></div>";
                //UnreadText += "<div class=\"mid-2\">";
                //UnreadText += "<p>" + DoctorPrescription.Description + "</p>";
                //UnreadText += "<div class=\"block\"></div>";
                //UnreadText += "<div class=\"clearfix\"></div>";
                //UnreadText += "</div></div><br /></div>";
                //ProductDiv2.InnerHtml = UnreadText;

                UnreadText += "<style>textarea{resize: none; overflow:hidden; border: none;text-align: justify; width:36em;} @media(max-width:414px){textarea{width:25em;}}</style>";
                UnreadText += "<div class=\"col-md-6 pro-6\">";
                UnreadText += "<div class=\"col-m\">";
                UnreadText += "<div class=\"women\"><a href = \"Herbs.aspx?id=" + DoctorPrescription.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorPrescription.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorPrescription.Doctor.FName + " " + DoctorPrescription.Doctor.LName + "(" + DoctorPrescription.Doctor.Specialty + " Specialist)</h4></center></a></div>";
                UnreadText += "<div class=\"mid-2\">";
                UnreadText += "<textarea rows=\"4\">" + DoctorPrescription.Description + "</textarea>";
                UnreadText += "<div class=\"block\"></div>";
                UnreadText += "<div class=\"clearfix\"></div>";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModalPrescription" + i + "\" class=\"btn btn-danger my-cart-btn my-cart-b\" data-id=\"24\">View Details</a>";
                UnreadText += "</div></div><br /></div>";

                UnreadText1 += "<div class=\"modal fade\" id=\"myModalPrescription" + i + "\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\">";
                UnreadText1 += "<div class=\"modal-dialog\" role=\"document\">";
                UnreadText1 += "<div class=\"modal-content modal-info\">";
                UnreadText1 += "<div class=\"modal-header\">";
                UnreadText1 += "<button type = \"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"modal-body modal-spa\">";
                UnreadText1 += "<div class=\"col-md-12 span-1\">";
                UnreadText1 += "<div class=\"women\"><center><u><h3>" + DoctorPrescription.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorPrescription.Doctor.FName + " " + DoctorPrescription.Doctor.LName + "(" + DoctorPrescription.Doctor.Specialty + " Specialist)</h4></center></div>";
                UnreadText1 += "<p class=\"in-para\" style=\"font-size:20px;\">" + DoctorPrescription.Description + "</p>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";

                ProductDiv2.InnerHtml = UnreadText;
                ProductDiv22.InnerHtml = UnreadText1;

                i++;
            }
        }
        else
        {
            msg2.Visible = true;
        }
    }

    public void BindDataTable3()
    {
        List<DoctorTips> listDoctorTips = new List<DoctorTips>();
        listDoctorTips = objDoctorTipsDataAccessLayer.GetTop4DoctorTips();

        String UnreadText = "", UnreadText1 = "";
        Int32 i = 1;
        if (listDoctorTips.Count > 0)
        {
            foreach (DoctorTips DoctorTip in listDoctorTips)
            {
                //UnreadText += "<div class=\"col-md-6 pro-6\">";
                //UnreadText += "<div class=\"col-m\">";
                //UnreadText += "<div class=\"women\"><a href = \"HerbsList.aspx?id=" + DoctorTip.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></a></div>";
                //UnreadText += "<div class=\"mid-2\">";
                //UnreadText += "<p>" + DoctorTip.Description + "</p>";
                //UnreadText += "<div class=\"block\"></div>";
                //UnreadText += "<div class=\"clearfix\"></div>";
                //UnreadText += "</div></div><br /></div>";
                //ProductDiv3.InnerHtml = UnreadText;

                UnreadText += "<style>textarea{resize: none; overflow:hidden; border: none;text-align: justify; width:36em;} @media(max-width:414px){textarea{width:25em;}}</style>";
                UnreadText += "<div class=\"col-md-6 pro-6\">";
                UnreadText += "<div class=\"col-m\">";
                UnreadText += "<div class=\"women\"><a href = \"Herbs.aspx?id=" + DoctorTip.ID + "\" class=\"offer-img\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></a></div>";
                UnreadText += "<div class=\"mid-2\">";
                UnreadText += "<textarea rows=\"4\">" + DoctorTip.Description + "</textarea>";
                UnreadText += "<div class=\"block\"></div>";
                UnreadText += "<div class=\"clearfix\"></div>";
                UnreadText += "<a href = \"#\" data-toggle=\"modal\" data-target=\"#myModalTip" + i + "\" class=\"btn btn-danger my-cart-btn my-cart-b\" data-id=\"24\">View Details</a>";
                UnreadText += "</div></div><br /></div>";

                UnreadText1 += "<div class=\"modal fade\" id=\"myModalTip" + i + "\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\">";
                UnreadText1 += "<div class=\"modal-dialog\" role=\"document\">";
                UnreadText1 += "<div class=\"modal-content modal-info\">";
                UnreadText1 += "<div class=\"modal-header\">";
                UnreadText1 += "<button type = \"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"modal-body modal-spa\">";
                UnreadText1 += "<div class=\"col-md-12 span-1\">";
                UnreadText1 += "<div class=\"women\"><center><u><h3>" + DoctorTip.Subject + "</h3></u><br/><h4>By: Dr. " + DoctorTip.Doctor.FName + " " + DoctorTip.Doctor.LName + "(" + DoctorTip.Doctor.Specialty + " Specialist)</h4></center></div>";
                UnreadText1 += "<p class=\"in-para\" style=\"font-size:20px;\">" + DoctorTip.Description + "</p>";
                UnreadText1 += "</div>";
                UnreadText1 += "<div class=\"clearfix\"></div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";
                UnreadText1 += "</div>";

                ProductDiv3.InnerHtml = UnreadText;
                ProductDiv32.InnerHtml = UnreadText1;

                i++;
            }
        }
        else
        {
            msg3.Visible = true;
        }
    }
}