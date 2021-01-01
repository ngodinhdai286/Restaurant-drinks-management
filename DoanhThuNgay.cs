using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class DoanhThuNgay
    {
        public static int date = 0;
        public int doanhThu { get; set; }
        List<NguoiDung> danhSachhoadontrongngay = new List<NguoiDung>();
        public DoanhThuNgay()
        {
            date++;
            this.doanhThu = 0;
        }
        public DoanhThuNgay(int thuNhap)
        {
            date++;
            this.doanhThu = thuNhap;
        }
        public DoanhThuNgay(DoanhThuNgay a)
        {
            date++;
            this.doanhThu = a.doanhThu;
        }
        public int tongDoanhThuTrongNgay()
        {
            int x = 0;
            foreach (NguoiDung a in danhSachhoadontrongngay)
            {
                x = x + a.orderDrink();
            }
            return x;
        }
    }
}
