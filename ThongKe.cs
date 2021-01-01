using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class ThongKe
    {
        //Thống kê các loại thức uống yêu thích được dùng nhiều trong tháng
        Dictionary<string, int> favoriteDrinking = new Dictionary<string, int>();

        //Thống kê số lượng nhập của các loại thức uống

        //Thống kê doanh thu của thức uống và số tiền lãi

        //Thống kê các loại thức uống yêu thích trong tháng
        public string thucUongYeuThich()
        {
            favoriteDrinking.Add("Coffee", Coffee.countCafe);
            favoriteDrinking.Add("Fruit", Fruit.countFruit);
            favoriteDrinking.Add("Beer", Beer.countBeer);
            favoriteDrinking.Add("RuouVang", RuouVang.countRuou);
            return "a";
        }
        public int doanhThuThang(List<DoanhThuNgay> thuNhap)
        {
            int money = 0;
            foreach (DoanhThuNgay a in thuNhap)
            {
                money = money + a.doanhThu;
            }
            return money;
        }
    }
}
