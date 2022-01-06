using System;

namespace HelloWorld
{
    class Program
    {
		static void DoIncrement(out int param)
		{
			param = 6;
		}
		static void Main(string[] args)
        {
            Console.Write("\nNhap name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !!");
			int a = 2;
			++a;
			DoIncrement(out a);
			Console.WriteLine(a);
			a++;
			Console.WriteLine(a);
			//Console.WriteLine(b);
			int x;
			x = 5;
			int y;
			y = x;
			x++;
			Console.WriteLine(x);
			Console.WriteLine(y);
			object c = "abc";
			object d = "abc";
			if (c == d)
			{
				Console.WriteLine("đúng");
			}
			else
			{
				Console.WriteLine("sai");
			}
			object obj;
			obj = 100;
			Console.WriteLine(obj);
			Loops lp = new Loops();
			Console.WriteLine("Lap for:");
			lp.LapFor();
			Console.WriteLine("Lap foreach:");
			lp.LapForeach();
			Console.WriteLine("Do while:");
			lp.LapDoWhile();
		}
    }
}
