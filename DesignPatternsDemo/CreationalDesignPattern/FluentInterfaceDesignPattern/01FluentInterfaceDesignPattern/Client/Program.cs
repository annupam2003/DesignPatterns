using FluentInterfaceDesignPattern;

namespace Client;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======< Fluent Interface Design Pattern >=========");
        FluentEmployee obj = new FluentEmployee();
        obj.NameOfTheEmployee("Anurag Mohanty")
                .AgeOfEmployee(18)
                .WorkingOn("IT")
                .StaysAt("Mumbai-India");

    }
}