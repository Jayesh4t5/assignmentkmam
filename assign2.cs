using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//wap to find out the digits which are divisible by 3

namespace assignmentkmam
{
    public class assign2
    {
        static void Main(string[] args)
        {
            int num;
            int digit;
            Console.WriteLine("Enter the Number:");
            num=Convert.ToInt32(Console.ReadLine());

            while (num>0) 
            {
                digit = num % 10;

                if (digit%3 == 0)
                {
                    Console.WriteLine(digit);

                }
                num = num / 10;

            }
            

        }
    }
}
