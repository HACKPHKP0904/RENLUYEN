using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_validate;
using Method_xuli;

namespace Menu_LuaChon
{
    public class luaChon
    {
        public static void meNu()
        {
            int luaChon;
            bool isKetQua;
            do
            {
                Console.WriteLine("Vui lòng chọn từ 1 đến 7:");
                Console.WriteLine("1. Tính giai thừa của số");
                Console.WriteLine("2. Liệt kê các số nguyên tố nhỏ hơn N");
                Console.WriteLine("3. Kiểm tra số chẵn hay lẻ");
                Console.WriteLine("4. Kiểm tra số đó có phải là số nguyên tố không?");
                Console.WriteLine("5. In ra mảng chẵn và mảng lẻ");
                Console.WriteLine("6. Sắp xếp dãy tăng dần và giảm dần");
                Console.WriteLine("7. Nhập vào số và in ra chữ");
                Console.Write("\nNhập lựa chọn của bạn vào : ");
                luaChon = check_validate.checkValidate.check_validate();
                isKetQua = true;
                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN TÍNH GIAI THỪA CỦA SỐ \n");
                        Method_xuli.xuLiGiaiThua.xuli_GiaiThua();
                        break;
                    case 2:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN LIỆT KÊ CÁC SỐ NGUYÊN TỐ NHỎ HƠN N\n");
                        Method_xuli.xuLiListSoNguyenTo.ListSoNguyenTo();
                        break;
                    case 3:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN KIỂM TRA SỐ CHẴN HAY LẺ ?\n");
                        Method_xuli.xuLiChanLe.xu_LiChanLe();
                        break;
                    case 4:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN KIỂM TRA SỐ ĐÓ CÓ PHẢI LÀ SỐ NGUYÊN TỐ KHÔNG?\n");
                        Method_xuli.xuLiSoNguyenTo.xuliSoNguyenTo();
                        break;
                    case 5:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN IN RA MẢNG CHẴN VÀ MẢNG LẺ\n");
                        Method_xuli.xuLiChanLe.check_list_chanle();
                        break;
                    case 6:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN SẮP XẾP DÃY TĂNG DẦN VÀ GIẢM DẦN\n");
                        Method_xuli.xuLiSapXep.daySapXep();
                        break;
                    case 7:
                        Console.WriteLine("========================================================================");
                        Console.WriteLine("BẠN ĐÃ CHỌN NHẬP VÀO SỐ VÀ IN RA CHỮ \n");
                        string ketQua = Method_xuli.xuLiChuyenDoiSo.imPortSo();
                        Console.WriteLine("Kết quả số đã chuyển là : {0}", ketQua);
                        break;
                    default:
                        Console.WriteLine();
                        isKetQua = false;
                        Console.WriteLine("========================================================================");
                        break;
                }
            } while (!isKetQua);
        }
    }
}
