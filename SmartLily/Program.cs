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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double phonePrice = double.Parse(Console.ReadLine());
            double lilyPresent = 0;
            double lilyMoney = 0;
            double brotherMoney = 0;

            for (int year = 1; year <= 100 ; year++)
            {
                if (year%2 != 0)
                {
                    lilyPresent += 1;
                    if (year > 1)
                    {
                        lilyPresent -= 1;
                        lilyMoney = lilyMoney + (year - 2);
                        lilyMoney -= 1;
                        brotherMoney += 1;
                    }
                }
                else
                {
                    lilyMoney += 10;
                    lilyMoney -= 1;
                    brotherMoney += 1;
                }

                if (lilyMoney >= phonePrice)
                {
                    Console.WriteLine($"Лили стана на {year} години, когато успя да си купи телефона!");
                    Console.WriteLine($"Брат й получи {brotherMoney} лева от Лили!");
                    Console.WriteLine($"След покупката на Лили ѝ останаха {lilyMoney - phonePrice} лева!");
                    break;
                }                
            }
            Console.ReadKey();
        }
        
    }
}
