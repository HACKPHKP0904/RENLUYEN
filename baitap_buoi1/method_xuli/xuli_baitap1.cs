using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_dulieu;
namespace method_xuli
{
    public class xuli_baitap1
    {
        public static double XuLi_baitap1(string luaChon)
        {
            int number1, number2;
            double ketQua = 0;
            Console.WriteLine("Nhập số thứ nhất");
            number1 = check_dulieu.check_dulieu.chekc_validate(); 
            Console.WriteLine("Nhập số thứ hai");
            number2 = check_dulieu.check_dulieu.chekc_validate();
            switch (luaChon)
            {
                case "+":
                    ketQua = number1 + number2;
                    Console.WriteLine("Tổng của 2 số là {0} ", number1 + number2);
                    break;
                case "-":
                    ketQua = number1 - number2;
                    Console.WriteLine("Hiệu của 2 số là {0}", number1 - number2);
                    break;
                case "*":
                    ketQua = number1 * number2; 
                    Console.WriteLine("Tích của 2 số là {0}", number1 * number2);
                    break;
                case "/":
                    if(number2 !=0)
                    {
                        ketQua = (float)number2 - number1;
                        Console.WriteLine("Thương của 2 số là {0}", (float)number1 / number2);
                    }
                    else
                    {
                        Console.WriteLine("Không thể chia cho mẫu số bằng 0 ");
                    }
                    break;
                default:
                    Console.WriteLine("Không có lựa chọn hợp lệ");
                    break;
            }
            return ketQua;
        
        }
    }
}
