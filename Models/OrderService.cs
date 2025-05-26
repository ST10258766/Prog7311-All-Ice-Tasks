namespace SolidOrderProcessing.Models
{
    public class OrderService : IOrderService
    {
        private readonly INotificationService _notificationService;
        private static readonly List<Product> _placedOrders = new List<Product>();

        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder(Product product)
        {
            // Mock processing
            Console.WriteLine($"Order placed for {product.Name}, Amount: {product.Price}");

            _notificationService.Notify($"Order confirmed for {product.Name}!");

            // Add to in-memory list
            _placedOrders.Add(product);
        }

        public static List<Product> GetPlacedOrders()
        {
            return _placedOrders;
        }
    }
}
