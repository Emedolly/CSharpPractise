namespace CSharpPractise.CsharpLessons.TopicWisePractice;

public class Employee
{
    protected string _name;
    protected double _baseSalary;
    public string ID;

    public Employee(string name, double baseSalary, string id)
    {
        this._name = name;
        this._baseSalary = baseSalary;
        this.ID = id;
    }

    public virtual double CalculateSalary()
    {
        return _baseSalary;
    }
}

public class Manager : Employee
{
    public double Bonus{get;set;}

    public Manager(string name, double baseSalary, string id,double bonus) : base(name, baseSalary, id)
    {
        this.Bonus=bonus;
    }

    public override double CalculateSalary()
    {
        return _baseSalary + Bonus;
    }
}