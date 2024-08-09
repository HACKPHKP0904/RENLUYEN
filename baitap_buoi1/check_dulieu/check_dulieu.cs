using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_dulieu
{
    public class check_dulieu
    {
        public static int chekc_validate()
        {
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Nhập lại:");
            }
            return number;
        }
    }
}
