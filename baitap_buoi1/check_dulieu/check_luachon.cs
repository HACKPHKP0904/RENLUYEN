using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_dulieu
{
    public class check_luachon
    {
        public static string checkLuaChon()
        {
            string luaChon = "";
            bool isLuachon = false;
            while (!isLuachon)
            {
                luaChon = Console.ReadLine();
                if (luaChon == "1" || luaChon == "2")
                {
                    isLuachon = true;
                }
                else
                {
                    Console.Write("Bạn đã chọn sai lựa chọn . Vui lòng chọn lại : ");
                }
            }
            return luaChon;
        }
        public static string checkPheptinh()
        {
            string luaChon = "";
            bool isLuaChon = false;
            while (!isLuaChon)
            {
                luaChon = Console.ReadLine();
                if (luaChon == "+" || luaChon == "-" || luaChon == "*" || luaChon == "/")
                {
                    isLuaChon = true;
                }
                else
                {
                    Console.WriteLine("Bạn đã lựa chọn sai . Vui lòng chọn lại (+,-,*,/) : ");
                }
            }
            return luaChon;
        }
    }
}
