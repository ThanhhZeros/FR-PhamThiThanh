using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassObject
{
    class Program
    {
        /*static private ArrayList ds = new ArrayList();
        //static private ArrayList<Student> ds = new List<Student>();
        static void Main(string[] args)
        {
            Shape sh = new Shape(5, 7);
            Console.WriteLine("Dien tich la: " + sh.DienTich());
            NhapThongTin();HienThi();
        }
        private static void NhapThongTin()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Score: ");
            float score = float.Parse(Console.ReadLine());
            Student s = new Student(name,age,score);
            ds.Add(s);
        }
        private static void HienThi()
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item.ToString());
            }
        }*/
        static void Main(string[] args)
        {

            int x;
            x = Int32.Parse(Console.ReadLine());
            if (x == 1)
            {
                throw new Exception("Loi nhe hehe");
            }
            else
                Console.Write("hiii");

        }
    }
}
