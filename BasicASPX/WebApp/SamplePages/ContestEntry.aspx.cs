using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {   // if we had a database the data would be stored there
        // using this static List<T> is ONLY done in this example because we have no database
        public static List<EntryCollection> ContestEntryCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            // test Page.IsPostBack to page initialization
            if(!Page.IsPostBack)
            {
                ContestEntryCollection = new List<EntryCollection>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            // validate the data coming in
            if (Page.IsValid)
            {
                // validate the user checking the terms
                if (Terms.Checked)
                {
                    //      yes: create/load entry, add to List, display List

                }
                else
                {
                    //       no: message
                    Message.Text = "you did not agree to the terms of this contest. Entry is Denied";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.SelectedIndex = 0;
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            Terms.Checked = false;
        }
    }
}