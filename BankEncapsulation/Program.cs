namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var accountOne = new BankAccount();
            accountOne.Deposit(600);
            Console.WriteLine(accountOne.GetBalance());
        }
    }
}
