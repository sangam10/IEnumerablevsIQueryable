namespace IEnumerableEQueryable;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var context = new ApplicationContext("Data Source=Employee.db");

        // IQueryable<Employee> employees = context.Employees;
        // IEnumerable<Employee> employees = context.Employees;
        var employees = context.Employees;
        var firstTwoEmployees = employees.Take(2);
        foreach (var item in firstTwoEmployees)
        {
            Console.WriteLine($"name:{item.FirstName} {item.LastName} address:{item.Address}");
        }
    }
}
