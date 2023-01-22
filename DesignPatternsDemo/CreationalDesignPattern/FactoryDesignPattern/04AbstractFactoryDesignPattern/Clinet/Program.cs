using AbstractFactoryDesignPattern;

namespace Client;
public class Program
{
    static void Main(string[] args)
    {
        IBankingService bankingService = null;
        BankingServiceFactory bankingServiceFactory = null;

        bankingServiceFactory = BankingServiceFactory.CreateBankingServiceFactory("CreditCard");
        Console.WriteLine(bankingServiceFactory.GetType().Name);

        bankingService = bankingServiceFactory.GetService("MoneyBack");
        if (bankingService != null)
        {
            Console.WriteLine(bankingService.GetType().Name);
            Console.WriteLine(bankingService.GetAmout());
        }
    }
}