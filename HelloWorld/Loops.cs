using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Loops
    {
        public void LapFor()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void LapForeach()
        {
            string[] cars = { "Honda", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
        public void LapDoWhile()
        {
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<20 );
        }
    }
}
