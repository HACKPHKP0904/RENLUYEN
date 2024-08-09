using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_xuli
{
    public class xuLiChanLe
    {
        public static void xu_LiChanLe()
        {
            int number;
            Console.Write("\nVui lòng nhập số vào để xử lí : ");
            number = check_validate.checkValidate.check_validate();
            if( number % 2 == 0)
            {
                Console.WriteLine("\nSố {0} là số chẵn ",number);
            }else
            {
                Console.WriteLine("\nSố {0} là số lẻ", number);
            }
           
        }
        public static List<int>check_list_chanle()
        {
            int number;
            Console.Write("\nVui lòng nhập số N vào : ");
            number = check_validate.checkValidate.check_validate();
            List<int> isPrimes = new List<int>();
            List<int> List_chan = new List<int>();
            List<int> List_le = new List<int>();
            for(int i = 1; i<= number;i++)
            {
                isPrimes.Add(i);
            }
            foreach (int i in isPrimes)
            {
                if (i % 2 == 0)
                {
                    List_chan.Add(i);
                }
                else
                {
                    List_le.Add(i);
                }
            }
            if (List_chan.Count > 0)
            {
                Console.Write("\nCác số chẵn : ");
                foreach (int i in List_chan)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Không có số chẵn nào");
            } 
            if(List_le.Count > 0)
            {
                Console.Write("\nCác số lẻ : ");
                foreach(int i in List_le)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Không có số lẻ nào ");
            }
            return isPrimes;
        }
    }
}
