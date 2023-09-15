using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopOnline
{
    public partial class Default : System.Web.UI.Page
    {
        

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
        }




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Super Mario 64", Description = "Platfomer classico di Nintendo 64." , Price = 29.99m, ImageUrl = "/Content/imgs/mario.jpg" },
            new Product { Id = 2, Name = "The Legend of Zelda: Ocarina of Time", Description = "Epico gioco di ruolo di avventura per Nintendo 64.", Price = 39.99m, ImageUrl = "/Content/imgs/zelda.jpg" },
            new Product { Id = 3, Name = "Final Fantasy VII", Description = "Gioco di ruolo epico di Square Enix.", Price = 19.99m, ImageUrl = "/Content/imgs/finalfantasy.png" },
            new Product { Id = 4, Name = "Diablo II", Description = "Gioco di ruolo d'azione della Blizzard Entertainment.", Price = 29.99m, ImageUrl = "/Content/imgs/diablo.jpg" },
            new Product { Id = 5, Name = "Counter-Strike 1.6", Description = "Sparatutto in prima persona molto popolare.", Price = 14.99m, ImageUrl = "/Content/imgs/cs.jpg" },
            new Product { Id = 6, Name = "The Sims", Description = "Simulatore di vita virtuale.", Price = 24.99m, ImageUrl = "/Content/imgs/thesims.png" },
            new Product { Id = 7, Name = "Grand Theft Auto: Vice City", Description = "Azione sandbox nella fittizia città di Vice City.", Price = 29.99m, ImageUrl = "/Content/imgs/gta.jpg" },
            new Product { Id = 8, Name = "Half-Life", Description = "Sparatutto in prima persona con una storia coinvolgente.", Price = 17.99m, ImageUrl = "/Content/imgs/halflife.jpg" },
            new Product { Id = 9, Name = "Metal Gear Solid", Description = "Azione e infiltrazione con un'iconica trama.", Price = 22.99m, ImageUrl = "/Content/imgs/mgs.jpg" },
            new Product { Id = 10, Name = "Halo: Combat Evolved", Description = "Sparatutto sci-fi per Xbox.", Price = 34.99m, ImageUrl = "/Content/imgs/halo.jpg" },
            new Product { Id = 11, Name = "Resident Evil 2", Description = "Survival horror con zombi.", Price = 12.99m, ImageUrl = "/Content/imgs/residentevil.jfif" },
            new Product { Id = 12, Name = "Tony Hawk's Pro Skater 2", Description = "Simulatore di skateboard adrenalinico.", Price = 19.99m, ImageUrl = "/Content/imgs/tony.jpg" },
            new Product { Id = 13, Name = "Max Payne", Description = "Sparatutto a tema noir con slow-motion.", Price = 44.99m, ImageUrl = "/Content/imgs/Maxpayne.jpg" },
            new Product { Id = 14, Name = "Sonic the Hedgehog 2", Description = "Platformer classico per Sega Genesis.", Price = 15.99m, ImageUrl = "/Content/imgs/sonic.jpg" },
            new Product { Id = 15, Name = "Grim Fandango", Description = "Avventura grafica comica di LucasArts.", Price = 27.99m, ImageUrl = "/Content/imgs/grim.jpg" },
            new Product { Id = 16, Name = "Age of Empires II", Description = "Strategia in tempo reale con epoche storiche.", Price = 31.99m, ImageUrl = "/Content/imgs/ages.png" },
            new Product { Id = 17, Name = "Baldur's Gate II: Shadows of Amn", Description = "GDR epico basato su Dungeons & Dragons.", Price = 21.99m, ImageUrl = "/Content/imgs/baldur.png" },
            new Product { Id = 18, Name = "Deus Ex", Description = "Gioco di ruolo d'azione cyberpunk.", Price = 39.99m, ImageUrl = "/Content/imgs/deusex.jpg" },
            new Product { Id = 19, Name = "Warcraft III: Reign of Chaos", Description = "Strategia in tempo reale della Blizzard Entertainment.", Price = 14.99m, ImageUrl = "/Content/imgs/warcraft.jpg" },
            new Product { Id = 20, Name = "Morrowind", Description = "GDR epico open-world della serie The Elder Scrolls.", Price = 29.99m, ImageUrl = "/Content/imgs/morrowind.jpg" }
        };

                ProductRepeater.DataSource = products;
                ProductRepeater.DataBind();
            }
        }

    protected void GoToCartButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }

    }


}