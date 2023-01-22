using AbstractFactoryDesignPattern;

namespace Client;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=======< Abstact Factory Design Pattern >=======");
        IBankingService bankingService = null;
        BankingMoneyServiceFactory bankingMoneyServiceFactory = null;

        bankingMoneyServiceFactory = BankingMoneyServiceFactory.CreateBankingServiceFactory ("Loan");
        Console.WriteLine(bankingMoneyServiceFactory.ToString());

        bankingService = bankingMoneyServiceFactory.GetService("Vehical");
        if (bankingService != null)
        {
            Console.WriteLine(bankingService.GetType().Name);
            Console.WriteLine($"Service Name : { bankingService.GetService()}");
            Console.WriteLine($"Maximum Limit : {bankingService.MaxLimit()}");
            Console.WriteLine($"Process Fee : {bankingService.Charges()}");
        }
    }
}
