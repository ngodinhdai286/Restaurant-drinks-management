using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class NguoiDung
    {
        //Danh sách thức uống một người order = một hóa đơn
        public List<ThucUong> order = new List<ThucUong>();

        public string nameDrink { get; set; }
        public int tienThanhToan { get; set; }
        public NguoiDung()
        {
            this.nameDrink = nameDrink;
            this.tienThanhToan = tienThanhToan;
            this.order = null;          
        }
        public NguoiDung(string tenDouong, int soLuong, int tienDua,List<ThucUong> a)
        {
            this.nameDrink = tenDouong;
            this.tienThanhToan = tienDua;
            this.order = a;
        }

        //Nếu 2 bàn thanh toán chung một hóa đơn
        public NguoiDung(NguoiDung a)
        {
            this.nameDrink = a.nameDrink;
            this.tienThanhToan = this.tienThanhToan + a.tienThanhToan;
            this.order = a.order;
        }

        //Gọi đồ uống
        public int orderDrink(params object[] parameters)
        {
            this.tienThanhToan = 18000 * (int)parameters[0] + 2000 * (int)parameters[1] + 25000 * (int)parameters[2] + 100000 * (int)parameters[3];
            return this.tienThanhToan;
        }

        public delegate int tienNhan(params object[] parameters);
        public int tienNhanvao(tienNhan A, params object[] parameters)
        {
            return A(parameters);
        }
        //Thanh toán
        public void thanhToan(int tienMat, tienNhan A, params object[] parameters)
        {
            Console.WriteLine("Nhà hàng nhận của quý khách: {0} VND", tienMat);
            Console.WriteLine("Số tiền trả lại: {0}", tienMat - tienNhanvao(A, parameters));
        }
    }
}
