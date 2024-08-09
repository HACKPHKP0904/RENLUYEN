using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_xuli
{
    public class xuLiListSoNguyenTo
    {
        public static List<int>ListSoNguyenTo()
        {
            int number;
            Console.Write("\nVui lòng nhập vào N:  ");
            number = check_validate.checkValidate.check_validate();
            if (number <= 1)
            {
                Console.WriteLine("Không có số nguyên tố ");
            }
            // bước 1: tạo mảng chứa số phần tử 
            bool[] isPrime = new bool[number];
            // bước 2 : tạo for để cho tất cả mảng đều là số nguyên tố
            // Cho tất cả các mảng đều là số nguyên tố 
            // ví dụ : N =4
            for (int i = 2; i < number; i++)
            {
                isPrime[i] = true;
                // [0] = false , [1] = false , [2] = true , [3] = true
            }
            //bước 3 : kiểm tra các phần tử array đó phải là số nguyên tố không nếu là số nguyên tố thì bỏ qua các bội
            // kiểm tra các số nào là số nguyên tố
            for (int i = 2; i < number; i++)
            {
                // [0] = false , [1] = false , [2] = true , [3] = true
                if (isPrime[i] == true)
                {
                    // kiểm tra bội nếu nó là true thì bỏ đi các bội của nó 
                    // ví dụ như nếu [2] là số nguyên tố thì bội nó là 4 8 bỏ 
                    for (int j = i * 2; j < number; j += i)
                    {
                        isPrime[j] = false;
                        //isPrime[4] = false mà do ta chỉ có tởi isPrime[3] thôi nên bỏ qua 
                    }
                }
            }
            // bước 4 : thu thập các mảng là true (tức là số nguyên tố)
            List<int> primes = new List<int>();
            for (int i = 2; i < number; i++)
            {
                if(isPrime[i] == true)
                {
                    primes.Add(i);
                }
            }
            // in ra kết quả 
            if (primes.Count > 0) 
            {
                Console.Write("\n--> Các số nguyên tổ nhỏ hơn {0}: ", number);
                // chạy qua từng phần tử của primes để in ra kết quả 
                foreach(int i in primes)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Không có số nguyên tố nào nhỏ hơn {0} ", number);
            }
            return primes;
            
        }
    }
}
