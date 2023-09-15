using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace ShopOnline
{
    public partial class Cart : System.Web.UI.Page
    {
        public List<Product> CartItems
        {
            get
            {
                if (Session["CartItems"] == null)
                {
                    Session["CartItems"] = new List<Product>();
                }
                return (List<Product>)Session["CartItems"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCartItems();
            }
        }

        private void BindCartItems()
        {
            CartGridView.DataSource = CartItems;
            CartGridView.DataBind();
        }


        protected void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).CommandArgument, out int productId))
            {
                
                int indexToRemove = -1;
                for (int i = 0; i < CartItems.Count; i++)
                {
                    if (CartItems[i].Id == productId)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                
                if (indexToRemove >= 0)
                {
                    CartItems.RemoveAt(indexToRemove);
                    BindCartItems();
                }
            }
        }




        protected void ClearCartButton_Click(object sender, EventArgs e)
        {
            CartItems.Clear();
            BindCartItems();
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }


    }
}


