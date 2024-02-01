namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var accountOne = new BankAccount();
            Console.WriteLine("How much would you like to deposit today?");
            double amountDeposited = double.Parse(Console.ReadLine());
            accountOne.Deposit(amountDeposited);
            
           double accountBalance = accountOne.GetBalance();

            Console.WriteLine($"Hi, your current balance is: {accountBalance, 0:c}");
        }
    }
}
