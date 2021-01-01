using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class Fruit : ThucUong
    {
        public static int countFruit = 0;
        public int fruitCount = 0;
        public Fruit()
        {
            this._name = "Fruit";
            this._price = 1400;
            this._nguyenLieu = "Các loại hương liệu tạo Coffee";
            this._giaVatlieu = 15000;
            this.fruitCount++;
            countFruit++;
        }
        public Fruit(Fruit f)
        {
            f._name = this._name;
            f._price = this._price;
            f.nguyenLieu = this._nguyenLieu;
            f.giaVatlieu = this.giaVatlieu;
            countFruit++;
            this.fruitCount++;
        }
        public Fruit(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countFruit++;
            this.fruitCount++;
        }
    }
}
