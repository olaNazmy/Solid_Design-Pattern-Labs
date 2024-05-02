using SOLID_OrderTask.Interfaces;

namespace SOLID_OrderTask
{
    internal class ECommerceSystem : IProductManager, IOrderProcessor
    {
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();
        private readonly IPaymentProcessor paymentProcessor;
        private readonly INotificationSender notificationSender;
        //Refactor Code
        public ECommerceSystem(IPaymentProcessor paymentProcessor, INotificationSender notificationSender)
        {
            this.paymentProcessor = paymentProcessor;
            this.notificationSender = notificationSender;
        }
        //

        public void AddProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product { Name = name, Price = price, Quantity = quantity });
        }

        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();
            foreach (var productId in productIds)
            {
                Product product = products.Find(p => p.Id == productId);
                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }
            if (orderedProducts.Count > 0)
            {
                paymentProcessor.ProcessPayment(totalCost);
                Order order = new Order
                {
                    CustomerName = customerName,
                    products = orderedProducts,
                    TotalCost = totalCost,
                };
                orders.Add(order);
                notificationSender.SendOrderConfirmationEmail(order);
            }
        }
    }
}
























        //private List<Product> products = new List<Product>();
        //private List<Order> orders = new List<Order>();
        ////add product
        //public void AddProduct(string Name, decimal Price, int quantity)
        //{
        //    products.Add(new Product { Name = Name, Price = Price, Quantity = quantity });
        //}
        ////place order
        //public void PlaceOrder(string CustomerName, List<int> ProductIds, string PaymentMethod)
        //{
        //    decimal totalCost = 0;
        //    List<Product> Orderedproducts = new List<Product>();
        //    foreach (var Productid in ProductIds)
        //    {
        //        Product product = products.Find(p => p.Id == Productid);
        //        if (product != null & product.Quantity > 0)
        //        {
        //            Orderedproducts.Add(product);
        //            totalCost += product.Price;
        //            product.Quantity--;
        //        }
        //    }
        //    //
        //    if (Orderedproducts.Count > 0)
        //    {
        //        if (PaymentMethod == "CreditCard")
        //        {
        //            ProcessCreditCardPayment(totalCost);
        //        }
        //        else if (PaymentMethod =="PayPal")
        //        {
        //            ProcessPayPalPayment(totalCost);
        //        }
        //        Order order = new Order
        //        {
        //            CustomerName = CustomerName,
        //            products = Orderedproducts,
        //            TotalCost= totalCost,
        //        };
        //        orders.Add(order);
        //        SendOrderConfirmationEmait(order);

        //    }
        //}

        ////process payment
        //private void ProcessCreditCardPayment(decimal amount)
        //{
        //    Console.WriteLine($"Payment by Credit Card {amount}");
        //}
        ////Paypal
        //private void ProcessPayPalPayment(decimal amount)
        //{
        //    Console.WriteLine($"Payment by PayPal Card {amount}");
        //}
        ////send email
        //private void SendOrderConfirmationEmait(Order order)
        //{
        //    string message = $"order confirmation email{order.CustomerName}:\n";
        //    message += $"total cost {order.TotalCost}\n";
        //    message += "Products:\n";
        //    foreach (Product product in order.products)
        //    {
        //        message += $"-{product.Name} ({product.Price}) \n";
        //    }
        //    //send email
        //    Console.WriteLine (message);    
        //}
        ////
