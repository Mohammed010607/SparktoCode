/*
 The Code Below is a 
 Total Salary + Bonus
 Calculator
 */

namespace Program1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Hours Worked This Month:");
        double hoursWorked = double.Parse(Console.ReadLine());
        double bonusRate;

        if (hoursWorked <= 180 && salary <= 2000 && hoursWorked >= 160)
        {
            bonusRate = 0.1;
        }
        else if (hoursWorked < 200 && salary <= 1700 && hoursWorked > 180)
        {
            bonusRate = 0.15;
        }
        else if (hoursWorked >= 220 && salary <= 1400)
        {
            bonusRate = 0.2;
        }
        else
        {
            bonusRate = 0;
        }
        
        //Calculates Bonus From This Month
        double bonusSalary = salary * bonusRate;
        Console.WriteLine("Your Bonus This Month is: $"  + bonusSalary);

        double StandardHourlyRate = salary / 160;
        double hoursShort = 160 - hoursWorked;

        //Work Hour Penalty calculation
        double penalty = 0;
        if (hoursWorked < 160)
        {
           penalty =  hoursShort* StandardHourlyRate;
        }
        
        Console.WriteLine("Your Penalty This Month is: $"  + penalty);
        
        //Calculates Salary + Bonus
        double total_salary = salary + bonusSalary - penalty;
        Console.WriteLine("Your Total Salary This Month is: $" + total_salary);
    }
}
