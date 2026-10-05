using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TechStoreCatalog.Models;

namespace TechStoreCatalog.Controllers
{
    public class CatalogController : Controller
    {
        private List<ProductItem> GetProducts()
        {
            return new List<ProductItem>
            {
                new ProductItem
                {
                    Id = 101,
                    Name = "Gaming Laptop",
                    Category = "Computers",
                    Price = 72000,
                    Details = "High performance laptop for gaming and development."
                },

                new ProductItem
                {
                    Id = 102,
                    Name = "Android Tablet",
                    Category = "Computers",
                    Price = 28000,
                    Details = "Portable tablet with a large display."
                },

                new ProductItem
                {
                    Id = 103,
                    Name = "Mechanical Keyboard",
                    Category = "Accessories",
                    Price = 6500,
                    Details = "RGB mechanical keyboard for coding and gaming."
                },

                new ProductItem
                {
                    Id = 104,
                    Name = "Wireless Mouse",
                    Category = "Accessories",
                    Price = 1800,
                    Details = "Comfortable wireless mouse for everyday use."
                }
            };
        }

        public ActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            var products = GetProducts();

            ProductItem selectedProduct =
                products.FirstOrDefault(p => p.Id == id);

            if (selectedProduct == null)
            {
                return HttpNotFound();
            }

            return View(selectedProduct);
        }
    }
}