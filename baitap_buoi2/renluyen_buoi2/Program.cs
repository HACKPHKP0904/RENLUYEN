using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_validate;
namespace renluyen_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in ra tiếng việt 
            Console.OutputEncoding = Encoding.UTF8;
            Menu_LuaChon.luaChon.meNu();
            Console.ReadLine(); 
        }
    }
}
