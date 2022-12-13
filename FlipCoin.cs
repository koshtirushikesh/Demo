using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            int headcount = 0;
            int tailcount = 0;


            Console.WriteLine("please enter the number of flip times");
            int flip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(flip +" times coine will flip");
            
        for (int i = 0; i<flip ; i++)
            {
                Random random = new Random();
                int num = random.Next(2);
                if (num == 0)
                {
                   tailcount++; 
                }
                else
                {
                   headcount++;
                }
            }
            Console.WriteLine("head cout is "+ headcount );
            Console.WriteLine("tail cout is "+ tailcount );

            int headpercent = headcount * 100 / flip;
            int tailpercent = tailcount * 100 / flip;

            Console.WriteLine("head percentage is " + headcount +"%");
            Console.WriteLine("head percentage is " + tailcount +"%");



        }
    }

}
