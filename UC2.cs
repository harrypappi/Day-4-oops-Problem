using System;

public class Employee
{
    public string Name { get; set; }
    public int WagePerHour { get; set; }
    public int FullDayHour { get; set; }

    public int CalculateDailyWage()
    {
        return WagePerHour * FullDayHour;
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee.Name = "Harishkumar";
        employee.WagePerHour = 20;
        employee.FullDayHour = 8;

        int dailyWage = employee.CalculateDailyWage();

        Console.WriteLine($"Daily wage of {employee.Name} is: {dailyWage}");
    }
}
