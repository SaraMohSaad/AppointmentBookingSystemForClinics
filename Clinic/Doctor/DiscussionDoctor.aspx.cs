﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic.Doctor
{
    public partial class DiscussionDoctor : System.Web.UI.Page
    {
        public static bool report=false;
        static Boolean textGroup;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;

            if (report)
            {
                report = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Reported successfully')", true);
            }

            if (MultiView1.GetActiveView() != addDisc)
            {

                MultiView1.SetActiveView(seeDisc);
                if (MultiView2.GetActiveView() != View2)
                    MultiView2.SetActiveView(View1);
            }
            else
            {
                if (MultiView2.GetActiveView() != View2)
                    MultiView2.SetActiveView(View1);
            }

        }
        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
        protected void wait2_Click(object sender, ImageClickEventArgs e)
        {
            note1.Visible = true;
            note2.Visible = false;
            disc1.Visible = false;
            disc2.Visible = true;
          //  loginbox.Attributes["class"] = "loginbox";
            MultiView1.SetActiveView(addDisc);
        }

        protected void shedule2_Click(object sender, ImageClickEventArgs e)
        {
            disc1.Visible = true;
            disc2.Visible = false;
            note1.Visible = false;
            note2.Visible = true;
            //loginbox.Attributes["class"] = "loginboxx";
            MultiView1.SetActiveView(seeDisc);
        }protected void pewpew(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('DiscussionPost.aspx"  + "','_blank');</script>");
        }

        protected void catgs(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('DiscussionGroud.aspx" + "','_blank');</script>");
            Session["textGroup"] = false;   
        }
        protected void catgs2(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('DiscussionGroud.aspx" + "','_blank');</script>");
            Session["textGroup"] = true;
        }
        protected void addpost(object sender, EventArgs e)
        {
            if (TextBox1.Text == null || TextBox1.Text == "")
            {
                Label2.Visible = true;
            }else
            {

            MultiView2.SetActiveView(View2);
            Label2.Visible=false;
            }
        }
      
        }
}