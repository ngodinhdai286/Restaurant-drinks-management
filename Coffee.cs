using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class Coffee : ThucUong
    {
        public static int countCafe = 0;
        public int coffeeCount = 0;
        public Coffee()
        {
            this._name = "Coffee";
            this._price = 1400;
            this._nguyenLieu = "Các loại hương liệu tạo Coffee";
            this._giaVatlieu = 15000;
            this.coffeeCount++;
            countCafe++;
        }
        public Coffee(Coffee c)
        {
            c._name = this._name;
            c._price = this._price;
            c.nguyenLieu = this._nguyenLieu;
            c.giaVatlieu = this.giaVatlieu;
            countCafe++;
            this.coffeeCount++;
        }
        public Coffee(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countCafe++;
            this.coffeeCount++;
        }
    }
}
