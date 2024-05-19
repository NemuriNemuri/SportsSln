using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart Cart;

        public CartSummaryViewComponent(Cart cart)
        {
            this.Cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(Cart);
        }
    }
}
