using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_validate
{
    public class checkValidate
    {
        public static int check_validate()
        {
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Bạn đã nhập sai . Vui lòng nhập lại : ");
            }
            return number;
        }
    }
}
