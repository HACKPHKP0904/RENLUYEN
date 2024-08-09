using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_dulieu;
using method_xuli;
namespace renluyen_buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai báo tiếng Việt 
            Console.OutputEncoding = Encoding.UTF8;
            //bài tập 1 
            Console.WriteLine("Bài tập 1 : Tính tổng 2 số , hiệu và tích 2 số");
            Console.WriteLine("Chọn các phép tính : + - * /");
            string luaChon = check_luachon.checkPheptinh();
            method_xuli.xuli_baitap1.XuLi_baitap1(luaChon);
            Console.ReadLine();
            // bài tập 2 
            Console.WriteLine("Bài tập 2 : Bài tập tính toán phương trình bậc nhất , bậc 2");
            Console.WriteLine("Lựa chọn : 1 hoặc 2 ");
            string luaChon_2 = check_luachon.checkLuaChon();
            method_xuli.xuli_baitap2.xuliPhuongtrinh(luaChon_2);
            Console.ReadLine();
            // bài tập 3 
            Console.WriteLine("Bài tập 3: Bài tập chuyển độ C thành độ K và độ F ");
            Console.WriteLine("Lựa chọn : 1 hoặc 2 ");
            string luachon_3 = check_luachon.checkLuaChon();
            method_xuli.xuli_baitap3.xuLiBaiTap3(luachon_3);
            Console.ReadLine();

        }
    }
}
