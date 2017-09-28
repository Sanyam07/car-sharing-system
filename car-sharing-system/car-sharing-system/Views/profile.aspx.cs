﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using car_sharing_system.Models;

namespace car_sharing_system.Admin_Theme.pages
{
    public partial class profile : System.Web.UI.Page
    {
        protected User newUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            newUser = DatabaseReader.userQuerySingle("accountID = '" + User.Identity.Name + "';");

            if (Request.QueryString["edit"] == "1")
            {
                showData.Visible = false;
                updateform.Visible = true;
                if (!IsPostBack) {
                    edfirstname.Text = newUser.fname;
                    edlastname.Text = newUser.lname;
                    edlicenseNo.Text = newUser.licenseNo;
                    edphone.Text = newUser.phone;
                    edstreet.Text = newUser.street;
                    edsuburb.Text = newUser.suburb;
                    edcity.Text = newUser.city;
                    edterritory.Text = newUser.territory;
                    edprofileURL.Text = newUser.profileURL;
                    edpostcode.Text = newUser.postcode;
                    edgender.Text = newUser.gender;
                    edbirth.Text = newUser.birth;
                }
            }
            else
            {
                showData.Visible = true;
                updateform.Visible = false;
                fN.InnerText = newUser.fname ;
                lN.InnerText = newUser.lname;
                LiN.InnerText = newUser.licenseNo;
                ph.InnerText = newUser.phone;
                st.InnerText = newUser.street;
                sb.InnerText = newUser.suburb;
                ci.InnerText = newUser.city;
                ter.InnerText = newUser.territory;
                pu.Src = newUser.profileURL;
                pc.InnerText = newUser.postcode;
                gen.InnerText = newUser.gender;
                dob.InnerText = newUser.birth;
            }
        }
        protected void submit(object sender, EventArgs e)
        {
            newUser = DatabaseReader.userQuerySingle("accountID = '" + User.Identity.Name + "';");
            newUser.fname = edfirstname.Text;
            newUser.lname = edlastname.Text;
            newUser.licenseNo = edlicenseNo.Text;
            newUser.phone = edphone.Text;
            newUser.street = edstreet.Text;
            newUser.suburb = edsuburb.Text;
            newUser.city = edcity.Text;
            newUser.territory = edterritory.Text;
            newUser.profileURL = edprofileURL.Text;
            newUser.postcode = edpostcode.Text;
            newUser.gender = edgender.Text;
            newUser.birth = edbirth.Text;
            DatabaseReader.updateProfile(newUser);

            Response.Redirect("/dashboard/profile?updated=1");
        }
    }
}