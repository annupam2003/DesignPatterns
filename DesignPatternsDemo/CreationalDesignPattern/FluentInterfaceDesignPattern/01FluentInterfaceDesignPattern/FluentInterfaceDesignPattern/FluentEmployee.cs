namespace FluentInterfaceDesignPattern;

public class FluentEmployee
{
    private Employee employee = new Employee();
    public FluentEmployee NameOfTheEmployee(string FullName)
    {
        employee.FullName = FullName;
        return this;
    }
    public FluentEmployee AgeOfEmployee(int Age)
    {
        employee.Age = Age;
        return this;
    }
    public FluentEmployee WorkingOn(string Department)
    {
        employee.Department = Department;
        return this;
    }
    public FluentEmployee StaysAt(string Address)
    {
        employee.Address = Address;
        return this;
    }
}