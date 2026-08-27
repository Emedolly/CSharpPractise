namespace CSharpPractise.DotnetLogicLab.Day06;

public abstract class EmployeeHierarchy
{
    public string Name;
    public int Id;

    public EmployeeHierarchy(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public abstract double CalculateSalary();

    public void PrintDetails()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Salary:{CalculateSalary()}");
    }
}

public class FullTimeEmployee : EmployeeHierarchy
{
    public double MonthlySalary;
    public FullTimeEmployee(string name, int id, double monthlySalary) : base(name, id)
    {
        MonthlySalary = monthlySalary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

public class PrintEmployee
{
     List<EmployeeHierarchy> employees = new List<EmployeeHierarchy>()
    {
        new FullTimeEmployee("Eme", 1765, 50000)
    };

    public void Print()
    {
        foreach (var emp in employees)
        {
           emp.PrintDetails();
        }
    }
}
