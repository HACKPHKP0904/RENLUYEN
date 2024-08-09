using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_dulieu;
namespace method_xuli
{
    public class xuli_baitap2
    {
        public static void xuliPhuongtrinh(string luaChon)
        {
            int number1, number2, number3;
            Console.WriteLine("Nhập vào số thứ nhất :");
            number1 = check_dulieu.check_dulieu.chekc_validate();
            Console.WriteLine("Nhập vào số thứ hai :");
            number2 = check_dulieu.check_dulieu.chekc_validate();
            Console.WriteLine("Nhập vào số thứ ba :");
            number3 = check_dulieu.check_dulieu.chekc_validate();
            switch (luaChon)
            {
                case "1":
                    Console.WriteLine("Bạn đã chọn giải phương trình bậc nhất");
                    Console.WriteLine("------Phương trình bậc nhất {0}x + {1} = 0------", number1,number2);
                    if(number1 != 0)
                    {
                        Console.WriteLine("Kết Quả : {0} ", (float)-number2 / number1);
                    }
                    else
                    {
                        Console.WriteLine("--> Phương trình này không phải là bậc 1 ");
                    }
                    break;
                case "2":
                    Console.WriteLine("Bạn đã chọn giải phương trình bậc hai");
                    Console.WriteLine("-------Phương trình bậc hai {0}x^2 + {1}x + {2} = 0------\n", number1, number2, number3);
                    if(number1 != 0)
                    {
                        if( number2 != 0)
                        {
                            if(number3 != 0)
                            {
                                double delta = 0 ;
                                delta = number2 * number2 - (4 * number1 * number3);
                                Console.WriteLine("Tính delta : {0}", delta);
                                if (delta > 0)
                                {
                                    double sqrtdelta = Math.Sqrt(delta);
                                    Console.WriteLine("------Phương trình có 2 nghiệm phân biệt------");
                                    Console.WriteLine("Nghiệm X1 = {0}", (-number2 + sqrtdelta) / (2 * number1));
                                    Console.WriteLine("Nghiệm X2 = {0}", (-number2 - sqrtdelta) / (2 * number1));
                                }
                                else if (delta == 0)
                                {
                                    Console.WriteLine("------Phương trình có nghiệm kép------");
                                    Console.WriteLine("Nghiệm X = {0}", -number2 / number1);
                                }
                                else
                                {
                                    Console.WriteLine("-->Phương trình vô nghiệm");
                                }
                            }
                            else
                            {
                                Console.WriteLine("------Phương trình {0}x^2 + {1}x = 0------",number1,number2);
                                Console.WriteLine("Nghiệm X1 = 0");
                                Console.WriteLine("Nghiệm X2 = {0}",(float)-number2/number1);
                            }
                            
                        }
                        else
                        {
                            if(number3 !=0)
                            {
                                Console.WriteLine("------Phương trình {0}x^2 + {1}=0------", number1, number3);
                                if (number1 < 0)
                                {
                                    Console.WriteLine("Nghiệm X1 : {0}", Math.Sqrt((float)number3 / number1));
                                    Console.WriteLine("Nghiệm X2 : {0}", Math.Sqrt((float)-number3 / number1));
                                }
                                else
                                {
                                    Console.WriteLine("-->Phương trình luôn có nghiệm dương");
                                }
                            }
                            else
                            {
                                Console.WriteLine("------Phương trình {0}x^2=0------",number1);
                                Console.WriteLine("Nghiệm X = 0");
                            }
                        }
                    }else
                    {
                        Console.WriteLine("------Phương trình {0}x + {1}=0------", number2, number3);
                        if(number2 !=0)
                        {
                            Console.WriteLine("Nghiệm X = {0}", (float)-number3 / number2);
                        }
                        else
                        {
                            Console.WriteLine("-->Không có nghiệm");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Chỉ chọn 1 hoặc 2");
                    break;
            }
        }
    }
}
