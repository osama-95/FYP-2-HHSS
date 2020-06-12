using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HerbsList : System.Web.UI.Page
{
    HerbsDataAccessLayer objHerbsDataAccessLayer = new HerbsDataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!this.IsPostBack)
        {
            BindDataTable();
        }
    }

    public void BindDataTable()
    {
        List<Herbs> listHerb = new List<Herbs>();

        listHerb = objHerbsDataAccessLayer.GetAllHerbs();
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
            msg.Visible = true;
        }
    }
}