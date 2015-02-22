using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class UserSignup : System.Web.UI.Page
{
    SmileAPIClient apiObj = new SmileAPIClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.message.Text = " Please enter verification code";
        EasyDrivedbDataContext db = new EasyDrivedbDataContext();
        if (Request.Form != null)
        {
            if (!string.IsNullOrEmpty(Request.Form["signupname"]) && !string.IsNullOrEmpty(Request.Form["signuppassword"])
                && !string.IsNullOrEmpty(Request.Form["signupmobile"]))
            {
                this.Session["signupname"] = Request.Form["signupname"];
                this.Session["verificationcode"] = (new Random(DateTime.Now.Second)).Next(1000, 9999).ToString();

                Users temp = new Users()
                {
                    Name = Request.Form["signupname"],
                    Mobile = Request.Form["signupmobile"],
                    Password = Request.Form["signuppassword"],
                    VerificationCode = (string)(this.Session["verificationcode"])
                };
                SMSSession session = apiObj.GetSession();
                bool result = apiObj.SendSMS(session, temp.Mobile, "thats your verification code for easy drive : " + temp.VerificationCode);
                if (result)
                    db.Users.InsertOnSubmit(temp);
            }
            else if (!string.IsNullOrEmpty(Request.Form["verificationcode"]))
            {
                if ((string)(Request.Form["verificationcode"]) == (string)(this.Session["verificationcode"]))
                {
                    var temp = from auser in db.Users
                               where auser.Name == (string)Session["signupname"]
                               select auser;
                    foreach (Users person in temp)
                    {
                        person.VerificationCode = (-1).ToString();
                    }
                }
                else
                    this.message.Text = "Verification code mismatch";
            }
            try
            {
                db.SubmitChanges();
                Response.Redirect("UserProfile.aspx");
            }
            catch (Exception)
            {

                message.Text = "DB connection error, please try later or email us at abrehman@hotmail.com";
            }
        }
    }

    protected void VerifyUser(object sender, EventArgs e)
    {

    }
}