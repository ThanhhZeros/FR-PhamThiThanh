using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape(5, 7);
            Console.WriteLine("Dien tich la: " + sh.DienTich());
        }
    }
}
