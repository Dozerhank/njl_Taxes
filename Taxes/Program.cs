using System;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Social Security number: ");
            string ssn = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Payroll Summary for: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
            Console.WriteLine("You earned {0} hours at {1} per hour", hours, payRate.ToString("F2"));
            Console.WriteLine("");

            double grossPay = hours * payRate;
            double federalTax = grossPay * .15;
            double stateTax = grossPay * .05;
            double netPay = grossPay - federalTax - stateTax;

            Console.WriteLine("Gross pay:           {0, 10}", grossPay.ToString("F2"));
            Console.WriteLine("Federal withholding: {0, 10}", federalTax.ToString("F2"));
            Console.WriteLine("State withholding:   {0, 10}", stateTax.ToString("F2"));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Net pay:             {0, 10}", netPay.ToString("F2"));
        }
    }
}
