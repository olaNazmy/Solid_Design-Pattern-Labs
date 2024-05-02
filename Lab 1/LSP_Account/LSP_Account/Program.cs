namespace LSP_Account
{
    internal class Program
    {
        //class account
        public abstract class Account
        {
            public decimal Balance { get; protected set; }

            public abstract void Withdraw(decimal amount);
        }

        public class RegularAccount : Account
        {
            public override void Withdraw(decimal amount)
            {
                if (amount > Balance)
                    throw new InvalidOperationException("Insufficient balance.");

                Balance -= amount;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }
        }


        //Saving Account 
        public class SavingsAccount : Account
        {
            public decimal InterestRate { get; set; }

            public override void Withdraw(decimal amount)
            {
                if (amount > Balance)
                    throw new InvalidOperationException("Insufficient balance.");

                Balance -= amount;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }
        }
    }
}
