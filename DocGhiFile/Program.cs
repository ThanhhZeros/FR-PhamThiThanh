using System;
using System.IO;

namespace DocGhiFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Noi dung trong file: ");
            /*string a = File.ReadAllText("D:/NTQ_Fresher/DemoCode/FR-PhamThiThanh/DocGhiFile/Text.txt");
            Console.WriteLine(a);*/
            string[] a = File.ReadAllLines("D:/NTQ_Fresher/DemoCode/FR-PhamThiThanh/DocGhiFile/Text.txt");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }
            string noidung = "Ghi file C# khong kho";
            //File.WriteAllText("D:/NTQ_Fresher/DemoCode/FR-PhamThiThanh/DocGhiFile/Text.txt", noidung);
            File.AppendAllText("D:/NTQ_Fresher/DemoCode/FR-PhamThiThanh/DocGhiFile/Text.txt", noidung);
            string b = File.ReadAllText("D:/NTQ_Fresher/DemoCode/FR-PhamThiThanh/DocGhiFile/Text.txt");
            Console.WriteLine(b);
        }
    }
}
