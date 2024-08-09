using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using checkValidate;
namespace renluyenbaitap_buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in ra tiếng việt được 
            Console.OutputEncoding = Encoding.UTF8;
            // Bài tập tìm tổng , tích , hiệu hai số
            Console.WriteLine("Bài tập tìm tổng , tích , hiệu hai số");
            int a;
            int b;
            Console.WriteLine("Nhập vào số thứ nhất");
            a = 
            //while (!checkValidate(out a))
            //{
            //    Console.WriteLine("Nhập lại :");
            //}
            Console.WriteLine("Nhập vào số thứ hai");
            b = check_Validate();
            //while (!checkValidate(out b))
            //{
            //    Console.WriteLine("Nhập lại :");
            //}
            Console.WriteLine("Nhập vào số thứ hai : ");
            Console.WriteLine("Tổng hai số là {0}", a + b);
            Console.WriteLine("Hiệu hai số là {0}", a - b);
            Console.WriteLine("Tích hai số là {0}", a * b);
            Console.ReadLine();
        }
        static bool checkValidate(out int number)
        {
            return int.TryParse(Console.ReadLine(), out number);
        }
       
    }
}
