using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_xuli
{
    public class xuLiSoNguyenTo
    {
        public static void xuliSoNguyenTo()
        {
            int number;
            Console.Write("\nVui lòng nhập số N : ");
            number = check_validate.checkValidate.check_validate();
            if ( number <= 1)
            {
                Console.WriteLine("Không phải số nguyên tố");
                return;
            }
            //number là ví dụ 
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if( number % i == 0 )
                {
                    Console.WriteLine("\nKhông phải là số nguyên tố");
                    return;
                }
            }
            Console.WriteLine("\n{0} là số nguyên tố", number);
        }
    }
}
