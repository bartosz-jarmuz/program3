using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputCounter;
            do
            {                 
                Console.WriteLine("Select counter type\r\n1.Text\r\n2.Numeric\r\n0.Exit");
                InputCounter = Console.ReadLine();
                if (InputCounter == "1")
                {
                    InputCounters(Convert.ToInt32(InputCounter));
                    
        
                }
                else if (InputCounter == "2")
                {

                }
                else if(InputCounter=="0")
                {
                    break;
                }
                else Console.WriteLine($"Can't recognize - {InputCounter}");

            } while (InputCounter!="0");
            
        }
        static public void InputCounters(int NumericOrText)
        {
            Console.WriteLine("Please input delay time:");
            string delayTime = Console.ReadLine();
            Console.WriteLine("Please input till when count:");
            string countTill = Console.ReadLine();

            if (NumericOrText==1)
            {
                int delayTimeInt = Convert.ToInt32(delayTime);
                int countTillInt = Convert.ToInt32(countTill);

            }
            else if (NumericOrText==2)
            {

            }

        }
    }
}
