using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using check_validate;

namespace Method_xuli
{
    public class xuLiGiaiThua
    {
        public static double xuli_GiaiThua()
        {
            int numBer;
            Console.Write("Vui lòng nhập số để tính giai thừa : ");
            numBer = check_validate.checkValidate.check_validate();
            double ketQua = 1;
            // xử lí giai thừa 
            for (int i = 1; i <= numBer;i++)
            {
                ketQua *= i;
            }
            Console.Write("\nKết quả giai thừa {0} = {1} \n ",numBer, ketQua);
            return ketQua;
        }
    }
}
