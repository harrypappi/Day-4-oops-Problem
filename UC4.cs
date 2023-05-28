using System;

public class Employee
{
    public string Name { get; set; }
    public int WagePerHour { get; set; }
    public int FullDayHour { get; set; }
    public int PartTimeHour { get; set; }

    public int CalculateDailyWage(string employeeType)
    {
        int dailyWage = 0;

        switch (employeeType)
        {
            case "FullTime":
                dailyWage = WagePerHour * FullDayHour;
                break;
            case "PartTime":
                dailyWage = WagePerHour * PartTimeHour;
                break;
            default:
                Console.WriteLine("Invalid employee type.");
                break;
        }

        return dailyWage;
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
        employee.PartTimeHour = 8;

        string employeeType = "FullTime";
        int dailyWage = employee.CalculateDailyWage(employeeType);

        Console.WriteLine($"Daily wage of {employee.Name} (Full Time) is: {dailyWage}");

        employeeType = "PartTime";
        dailyWage = employee.CalculateDailyWage(employeeType);

        Console.WriteLine($"Daily wage of {employee.Name} (Part Time) is: {dailyWage}");
    }
}
