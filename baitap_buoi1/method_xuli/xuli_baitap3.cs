using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_dulieu;
namespace method_xuli
{
    public class xuli_baitap3
    {
        public static void xuLiBaiTap3(string luaChon)
        {
            double doC = 0;
            Console.WriteLine("Nhập độ C ");
            doC = check_dulieu.check_dulieu.chekc_validate();
            switch(luaChon)
            {
                case "1":
                    Console.WriteLine("Bạn đã chọn chuyển độ K ");
                    double doK = 0;
                    doK = 1 * doC + 273;
                    Console.WriteLine("Độ K : {0}",doK);
                    break;
                case "2":
                    Console.WriteLine("Bạn đã chọn chuyển độ F ");
                    double doF = 0;
                    doF = doC * 18 / 10 + 32;
                    Console.WriteLine("Độ F : {0}", doF);
                    break;
                default:
                    Console.WriteLine("Bạn đã chọn sai lựa chọn ");
                    break;
            }
        }
    }
}
