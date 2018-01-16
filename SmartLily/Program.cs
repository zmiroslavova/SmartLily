using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the price on the phone: ");
            double phonePrice = double.Parse(Console.ReadLine());
            double lillyPresents = 0;
            double lillyMoney = 0;
            double brotherMoney = 0;

            for (int year = 1; year <= 100 ; year++)
            {
                if (year%2 != 0)
                {
                    lillyPresents += 1;
                    if (year > 1)
                    {
                        lillyPresents -= 1;
                        lillyMoney = lillyMoney + (year - 2);
                        lillyMoney -= 1;
                        brotherMoney += 1;
                    }
                }
                else
                {
                    lillyMoney += (10*year)/2;
                    lillyMoney -= 1;
                    brotherMoney += 1;
                }

                if (lillyMoney >= phonePrice)
                {
                    Console.WriteLine($"Lilly became {year} years old when she was able to buy the phone!");
                    Console.WriteLine($"Her brother received {brotherMoney}$ from Lilly!");
                    Console.WriteLine($"After the purchase Lilly has {lillyMoney - phonePrice}$ remaining!");
                    break;
                }                
            }
            Console.ReadKey();
        }
        
    }
}
