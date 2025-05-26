using Microsoft.AspNetCore.Mvc;
using SolidOrderProcessing.Models;

namespace SolidOrderProcessing.Controllers
{
    public class OrderController : Controller
    {
        private readonly INotificationFactory _notificationFactory;

        public OrderController(INotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(string productName, decimal productPrice, string notificationType)
        {
            var notificationService = _notificationFactory.GetNotificationService(notificationType);

            if (notificationService == null)
            {
                TempData["Message"] = $"❌ Invalid notification type selected.";
                return RedirectToAction("PlaceOrder");
            }

            var orderService = new OrderService(notificationService);

            var product = new Product
            {
                Name = productName,
                Price = productPrice
            };

            orderService.PlaceOrder(product);

            TempData["Message"] = $"✅ Successfully placed order for {productName} using {notificationType.ToUpper()} notification!";

            return RedirectToAction("ProductList");
        }


        public IActionResult ProductList()
        {
            var products = OrderService.GetPlacedOrders();
            

            return View(products);
        }
    }
}
