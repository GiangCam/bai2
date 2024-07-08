using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class phimvideo
    {
        public string Tenphim { get; set; }
        public string Daovien { get; set; }
        public string Theloai { get; set; }
        public int Nsxuat { get; set; }
        public string Hsx { get; set; }
        public string Tendvn { get; set; }
        public string Tendvnam { get; set; }

        public phimvideo(string theloai, string Nsxuat, string hsx,string daovien, string tenndvn, string tenndvnam, string tenphim)
        {
            Theloai = theloai;
            Daovien = daovien;
            Nsxuat = Nsxuat;
            Hsx = hsx;
            Tendvn = tenndvn;
            Tendvnam = tenndvnam;
            Tenphim = tenphim;
        }
        public void Hienthiphimvideo()
        {
            Console.WriteLine("Ten phimvideo: " + Tenphim);
            Console.WriteLine("Ten theloai: " + Theloai);
            Console.WriteLine("Ten Tendvn: " + Tendvn);
            Console.WriteLine("Ten Tendvnam: " + Tendvnam);
            Console.WriteLine("Nsxuat:" + Nsxuat);
            Console.WriteLine("Hsx:" + Hsx);
            Console.WriteLine();
        }
    }
}
