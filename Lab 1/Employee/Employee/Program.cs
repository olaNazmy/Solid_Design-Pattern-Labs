namespace Employee
{
    internal class Program
    {
        //part 1 separate employee class, properities
        public class Employee
        {
            public string Name { get; set; } 
            public decimal Salary {  get; set; }
            public string Department {  get; set; }

        }
        //2- every method have it's own functionality A-
        public class CalculateYearlySalary 
        {
            public decimal CalculateYearysalary(Employee employee)
            {
                return employee.Salary *12;
            }
        }

        // B==>
        public class ReportGenerator
        {
            public void Report(string reportType)
            {
                //code to generate report
                Console.WriteLine($"Generating {reportType} report...");
            }
        }
        // C
        public class SendNotification
        {
            public void SendNotificationMethod(string message,string recipient)
            {
                //code to send email notification
                Console.WriteLine($"Sending email notification to {recipient}: {message}");

            }
        }


        static void Main(string[] args)
        {

            // Create an instance of Employee
            Employee employee = new Employee
            {
                Name = "Ola nazmy",
                Salary = 50000,
                Department = "SD"
            };

            // Calculate yearly salary
            CalculateYearlySalary salaryCalculator = new CalculateYearlySalary();
            decimal yearlySalary = salaryCalculator.CalculateYearysalary(employee);
            Console.WriteLine($"Yearly salary for {employee.Name}: {yearlySalary:C}");

            // Generate a report
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.Report("Monthly");

            // Send a notification
            SendNotification notifier = new SendNotification();
            notifier.SendNotificationMethod("Your monthly report is ready.", "ola@gmail.com");

        }
    }
}
