using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_xuli
{
    public class xuLiChuyenDoiSo
    {
        private static string[] Units = { "", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín " };
        private static string[] Tens = { "", "mười ", "hai mươi ", "ba mươi ", "bốn mươi ", "năm mươi ", "sáu mươi ", "bảy mươi ", "tám mươi ", "chín mươi " };
        private static string[] Teens = { "", "mười một", "mười hai", "mười ba", "mười bốn", "mười năm", "mười sáu", "mười bảy", "mười tám", "mười chín"};
        public static string chuyenDoiSo(int number)
        {

            if(number == 0)
            {
                return "không";
            }
            if (number < 0)
            {
                return "âm" + chuyenDoiSo(-number);
            }
            // ví dụ : 101
            string words = "";
            if((number /100) > 0)
            {
                words += Units[number / 100] + "trăm" + " "; // lúc này word = 101/100 được 1 thì sẽ lấy 1 ra trong units và cộng với từ trăm 
                number %= 100; // dòng này là 101/100 thì phần dư còn lại là 1 thì lúc này number =1 

            }
            if(number > 0) // number =1 > 0
            {
                if(number < 10) // thỏa mãn 1 < 10 
                {
                    words += Units[number]; // lúc này words = vào unit lấy Units[1] là chữ một ra 
                }else if(number <20)
                {
                    words += Teens[number-10];
                }
                else
                {
                    words += Tens[number/10] + " "; 
                    if((number % 10) > 0) 
                    {
                        words += "" + Units[number % 10]; 
                    }
                }
            }
            return words.Trim(); // hàm Trim là để bỏ dấu khoảng trắng ở đầu và cuối chữ 
        }
        public static string imPortSo()
        {
            Console.WriteLine("Nhập vào số cần chuyển :");
            int number = check_validate.checkValidate.check_validate();
            return chuyenDoiSo(number);
        }
    }
}
