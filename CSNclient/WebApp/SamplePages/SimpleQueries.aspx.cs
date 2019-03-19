﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces 
using NorthwindSystem.BLL;
using NorthwindSystem.Data;
#endregion

namespace WebApp.SamplePages
{
    public partial class SimpleQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // clear old messages 
            MessageLabel.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int productid = 0;
            // validate your input
            if (string.IsNullOrEmpty(SearchArg.Text.Trim()))
            {
                // bad: message to user
                MessageLabel.Text = "Product ID is Required";
            }
            else if (int.TryParse(SearchArg.Text, out productid))
            { 
                // good: Standard Lookup Pattern and Display
                // since we are leaving this project (WebApp) 
                //    and going to another project (BLL) user friendly
                //    error handling is required
                try
                {
                    // create an instance of the appropriate BLL Class
                    ProductController sysmgr = new ProductController();
                    // issue your request to the appropriate BLL class method
                    Product results = sysmgr.Product_Get(int.Parse(SearchArg.Text));
                    // test results to see if anything was found
                    // null: product id not found
                    // otherwise: product instance3 exists
                    if(results == null)
                    {
                        // bad: message to user
                        MessageLabel.Text = "no data found for supplied ID";
                    }
                    else
                    {
                        // good: found
                        ProductID.Text = results.ProductID.ToString();
                        ProductName.Text = results.ProductName.ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
            else
            {
                // bad: message to user
                MessageLabel.Text = "Product ID must be a number greater than 0";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            SearchArg.Text = "";
            ProductID.Text = "";
            ProductName.Text = "";
        }
    }
}