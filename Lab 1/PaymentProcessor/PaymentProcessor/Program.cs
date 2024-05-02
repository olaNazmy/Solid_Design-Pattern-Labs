namespace PaymentProcessor
{
    internal class Program
    {
        //1-make class for credit
        public class CreditCardPaymentHandler : PaymentHandler
        {
            public void process(double amount)
            {
                // Process credit card payment
            }
        }

        //2- paypal payment handler
        public class PayPalPaymentHandler : PaymentHandler
        {
            public void process(double amount)
            {
                // Process paypal payment
            }
        }

        //3- bank transfer
        public class BankPaymentHandler : PaymentHandler
        {
            public void process(double amount)
            {
                // Process bank  payment
            }
        }
        //4- main for payment handler
        // Define the PaymentProcessor class
        public class PaymentProcessor
        {
            public void processPayment(double amount, PaymentHandler handler)
            {
                handler.process(amount);
            }
            static void Main(string[] args)
            {

                PaymentProcessor processor = new PaymentProcessor();

                // Process credit card payment
                PaymentHandler creditCardHandler = new CreditCardPaymentHandler();
                processor.processPayment(100.0, creditCardHandler);
            }

        }
    }
}
