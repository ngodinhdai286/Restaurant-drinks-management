using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Danh sách hóa đơn trong 1 ngày
            List<NguoiDung> hoaDon = new List<NguoiDung>();

            //Quản lí danh sách doanh thu ngày
            List<DoanhThuNgay> tienThang = new List<DoanhThuNgay>();

            //Tạo ra hóa đơn doanh thu một ngày sau đó thêm vào doanh thu ngày
            DoanhThuNgay tienNgay = new DoanhThuNgay();

            NguoiDung User = new NguoiDung();

            int selection = 0;
            while (selection != 5)
            {
                Console.WriteLine("          CHÀO MỪNG BẠN ĐẾN VỚI CỬA HÀNG CỦA CHÚNG TÔI!");
                Console.WriteLine("---------------------MỜI BẠN CHỌN THỨC UỐNG---------------------");
                Console.WriteLine("         Đồ uống                                 Giá(VNĐ)      ");
                Console.WriteLine("         1.Coffee---------------------------------18000             ");
                Console.WriteLine("         2.Nước ép--------------------------------20000            ");
                Console.WriteLine("         3.Beer-----------------------------------25000            ");
                Console.WriteLine("         4.Rượu vang------------------------------100000          ");
                Console.WriteLine("         5.Không chọn nữa                                                       ");
                int countCoffee = 0;
                int countFruit = 0;
                int countBeer = 0;
                int countRuou = 0;
                List<ThucUong> orderMenu = new List<ThucUong>();
                while (true)
                {
                    Console.WriteLine("Mời quý khách chọn: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        countCoffee++;
                        ThucUong a = new Coffee();
                        orderMenu.Add(a);
                    }
                    if (choice == 2)
                    {
                        countFruit++;
                        ThucUong b = new Coffee();
                        orderMenu.Add(b);
                    }
                    if (choice == 3)
                    {
                        countBeer++;
                        ThucUong c = new Coffee();
                        orderMenu.Add(c);
                    }
                    if (choice == 4)
                    {
                        countRuou++;
                        ThucUong d = new RuouVang();
                        orderMenu.Add(d);
                    }
                    if (choice == 5)
                    {
                        break;
                    }
                    Console.WriteLine("HÓA ĐƠN CỦA QUÝ KHÁCH BAO GỒM ");
                    Console.WriteLine("Thức uống          Số lượng         Thành tiền");
                    Console.WriteLine("1.Coffee             " + countCoffee + "                " + countCoffee * 18000);
                    Console.WriteLine("2.Nước ép            " + countFruit + "                " + countFruit * 20000);
                    Console.WriteLine("3.Bia                " + countBeer + "                " + countBeer * 25000);
                    Console.WriteLine("4.Rượu vang          " + countRuou + "                " + countRuou * 100000);
                    Console.WriteLine("TỔNG SỐ TIỀN BẠN CẦN THANH TOÁN: " + (countCoffee * 18000 + countFruit * 20000 + countBeer * 25000 + countRuou * 100000));
                    Console.WriteLine("Thuế VAT: 0VND");
                    NguoiDung.tienNhan receiveMoney = new NguoiDung.tienNhan(User.orderDrink);
                    Console.Write("SỐ TIỀN NHẬN CỦA KHÁCH HÀNG : ");
                    int tienKhachhang = int.Parse(Console.ReadLine());
                    User.thanhToan(tienKhachhang, receiveMoney, countCoffee, countFruit, countBeer, countRuou);
                    //Thêm hóa đơn vào trong List hóa đơn trong ngày
                    hoaDon.Add(User);

                    selection++;
                }
                //Tính tiền doanh thu trong 1 ngày
                int tien = 0;
                for (int i = 0; i < hoaDon.Count; i++)
                {
                    Console.WriteLine("Hóa đơn người thứ " + i);
                    Console.WriteLine(hoaDon[i].tienThanhToan);
                    tien = tien + hoaDon[i].tienThanhToan;
                }

                Console.WriteLine("Hóa đơn trong ngày có doanh thu là: " + tien);
                //Gán doanh thu 1 ngày cho tiền tổng hóa đơn vừa tìm được

                //Console.WriteLine(Coffee.countCafe);
                //ThongKe thongKe = new ThongKe();
                //thongKe.doanhThuThang(tienThang);
                //Console.WriteLine(thongKe);



                Console.ReadKey();
            }
        }
    }
}
