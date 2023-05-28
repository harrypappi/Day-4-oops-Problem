using System;

public class Employee
{
    public string Name { get; set; }

    public bool IsPresent()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee.Name = "Harishkumar";

        bool isPresent = employee.IsPresent();

        if (isPresent)
        {
            Console.WriteLine($"{employee.Name} is present.");
        }
        else
        {
            Console.WriteLine($"{employee.Name} is absent.");
        }
    }
}
