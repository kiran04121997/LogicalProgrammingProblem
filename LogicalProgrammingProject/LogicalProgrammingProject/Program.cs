using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welocome to logical programming");
            // FibonacciSeries.Fibonacci();//
            /* PerfectNumber perfectnum = new PerfectNumber();
             perfectnum.Perfect();*/
            //PrimeNumber.FindPrimeNumbers();//
            //ReverseNumber.FindReverseNumber();//
            /* CouponNumbers kiran = new CouponNumbers();
              kiran.findcouponsNumbers();*/
            /* StopwatchProgram bhosale = new StopwatchProgram();
               bhosale.Elapsetime();*/
            /* VendingMachine vending = new VendingMachine();
               vending.Getchange(1500);*/
            /* DayOfWeek weekday = new DayOfWeek();
             Console.WriteLine("Enter day");
             int day = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter month");
             int Month = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter year");
             int year = Convert.ToInt32(Console.ReadLine());
             weekday.Day(day, Month, year);*/
            /* TempConversion temperature = new TempConversion();
             Console.WriteLine("Enter value of temperature ");
             int temp = Convert.ToInt32(Console.ReadLine());
             temperature.temperatureconversion(temp);*/
            /*MonthlyPayment month = new MonthlyPayment();
            Console.WriteLine("Enter the value of principal");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate : ");
            double R = Convert.ToDouble(Console.ReadLine());
            month.monthlypayment(p, y, R);*/
            /* SquareRoot.Sqrt();*/
            /* BinaryConversion bin = new BinaryConversion();
             bin.decimalToBinary();*/
            SwapNibles obj12 = new SwapNibles();
            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            obj12.ToBinary(number);
            






            Console.ReadLine();
        }
    }
}
