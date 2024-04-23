using Microsoft.AspNetCore.Mvc;

namespace Ekart.Models
{
    public class CartController : Controller
    {
        public CartController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCartInfo(int cartID)
        {
            return View();
        }

        public IActionResult RemoveItemfromCart(int cartId, int itemId)
        {
            return View();
        }

        public IActionResult addItemInCart(int cartId, Products product)
        {
            return View();
        }

    }
}
