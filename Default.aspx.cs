using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    EasyDrivedbDataContext db = new EasyDrivedbDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.Form["loginmobile"]) && !string.IsNullOrEmpty(Request.Form["loginpassword"]))
        {
            var results = from userdata in db.Users
                          where userdata.Mobile == Request.Form["loginmobile"] && userdata.Password == Request.Form["loginpassword"]
                          select userdata;

            if(results.Count() > 0)
                Session["loginmobile"] = Request.Form["loginmobile"];
        }
    }
}