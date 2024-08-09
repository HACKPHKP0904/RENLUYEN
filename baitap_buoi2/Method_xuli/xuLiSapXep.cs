using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_xuli
{
    public class xuLiSapXep
    {
        public static List<int>daySapXep()
        {
            int number;
            Console.Write("\nVui lòng nhập số N vào :");
            number = check_validate.checkValidate.check_validate();
            List<int> isSapXep = new List<int>();
            for(int i = 1; i <= number;i++)
            {
                isSapXep.Add(i);
            }
            // sắp xếp tăng dần
            for (int i = 0; i < isSapXep.Count; i++)
            {
                for(int j = i+ 1; j <isSapXep.Count;j++)
                {
                    if (isSapXep[i] > isSapXep[j])
                    {
                        int item = isSapXep[i];
                        isSapXep[i] =isSapXep[j];
                        isSapXep[j] = item;
                    }
                }
            }
            Console.Write("\nDãy sau khi sắp xếp tăng dần :");
            foreach(int i in isSapXep)
            { 
                Console.Write(i + " "); 
            }
            Console.WriteLine();
            // sắp xếp giảm dần 
            for (int i = 0; i < isSapXep.Count -1 ; i++)
            {
                for (int j = i + 1; j < isSapXep.Count; j++)
                {
                    if (isSapXep[i] < isSapXep[j])
                    {
                        int item = isSapXep[i];
                        isSapXep[i] = isSapXep[j];
                        isSapXep[j] = item;
                    }
                }
            }
            Console.Write("\nDãy sau khi sắp xếp giảm dần :");
            foreach (int i in isSapXep)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            return isSapXep;
        }
    }
}
