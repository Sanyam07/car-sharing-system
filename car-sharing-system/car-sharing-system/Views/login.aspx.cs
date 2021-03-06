﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using car_sharing_system.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Cryptography;
using Rework;
using System.Diagnostics;

namespace car_sharing_system.Admin_Theme.pages
{
    public partial class login : System.Web.UI.Page
    {

		String redirect, carid;
		int sdate, edate;

        protected void Page_Load(object sender, EventArgs e) {
			redirect = Request.QueryString["redirect"];

			if (redirect != null) {
				if (redirect.Equals("/dashboard/confirmation")) {
					carid = Request.QueryString["id"];
					sdate = Int32.Parse(Request.QueryString["sdate"]);
					edate = Int32.Parse(Request.QueryString["edate"]);
				}
			}


			// I don't think this do anything
			 Login1.DestinationPageUrl = "/dashboard/profile";
		}
        protected void ValidateUser(object sender, EventArgs e)
        {
            String password = new User().hashMe(Login1.Password);
            User myData = UserModel.loginAttempt(Login1.UserName, password);
            if (myData != null)
            {
				//FormsAuthentication.RedirectFromLoginPage(myData.id.ToString(), Login1.RememberMeSet);

		        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
				  myData.id.ToString(), // userID
				  DateTime.Now,
				  DateTime.Now.AddMinutes(30),
				  Login1.RememberMeSet, // rememberme tick
				  myData.permission.ToString(), // user permission 
				  FormsAuthentication.FormsCookiePath);

				// Encrypt the ticket.
				string encTicket = FormsAuthentication.Encrypt(ticket);

				// Create the cookie.
				Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

				// Redirect back to original URL.
				Response.Redirect(FormsAuthentication.GetRedirectUrl(myData.id.ToString(), Login1.RememberMeSet));


				//FormsAuthentication.SetAuthCookie(myData.id.ToString(), Login1.RememberMeSet);

				if (redirect != null) {
					if (carid != null) {
						Response.Redirect(redirect + "?id=" + carid + " &sdate=" + sdate + " &edate=" + edate,false);
						return;
					} else {
						Response.Redirect(redirect, false);
						return;
					}
				} else {
					Response.Redirect("/dashboard/", false);
					return;
				}
			}
            else
            {
                Login1.FailureText = "Invalid Email or Password, Please try again.";
            }

        }

    }
}