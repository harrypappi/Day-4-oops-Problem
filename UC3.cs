using System;

public class Employee
{
    public string Name { get; set; }
    public int WagePerHour { get; set; }
    public int FullDayHour { get; set; }
    public int PartTimeHour { get; set; }

    public int CalculateDailyWage(bool isFullTime)
    {
        if (isFullTime)
        {
            return WagePerHour * FullDayHour;
        }
        else
        {
            return WagePerHour * PartTimeHour;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Employee fullTimeEmployee = new Employee();
        fullTimeEmployee.Name = "Harry";
        fullTimeEmployee.WagePerHour = 20;
        fullTimeEmployee.FullDayHour = 8;
        fullTimeEmployee.PartTimeHour = 8;

        int fullTimeWage = fullTimeEmployee.CalculateDailyWage(true);

        Console.WriteLine($"Daily wage of {fullTimeEmployee.Name} (Full Time) is: {fullTimeWage}");

        Employee partTimeEmployee = new Employee();
        partTimeEmployee.Name = "pappi";
        partTimeEmployee.WagePerHour = 15;
        partTimeEmployee.FullDayHour = 8;
        partTimeEmployee.PartTimeHour = 8;

        int partTimeWage = partTimeEmployee.CalculateDailyWage(false);

        Console.WriteLine($"Daily wage of {partTimeEmployee.Name} (Part Time) is: {partTimeWage}");
    }
}
