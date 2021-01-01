using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class RuouVang : ThucUong
    {
        public static int countRuou = 0;
        public int RuouVangcount = 0;
        public RuouVang()
        {
            this._name = "Beer";
            this._price = 1400;
            this._nguyenLieu = "Các loại hương liệu tạo Coffee";
            this._giaVatlieu = 15000;
            this.RuouVangcount++;
            countRuou++;
        }
        public RuouVang(RuouVang r)
        {
            r._name = this._name;
            r._price = this._price;
            r.nguyenLieu = this._nguyenLieu;
            r.giaVatlieu = this.giaVatlieu;
            countRuou++;
            this.RuouVangcount++;
        }
        public RuouVang(string ten, int price, string nguyenLieu, int giaNguyenlieu)
        {
            this._name = name;
            this._price = price;
            this.giaVatlieu = giaNguyenlieu;
            this._nguyenLieu = nguyenLieu;
            countRuou++;
            this.RuouVangcount++;
        }
    }
}
