using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest01
{
    internal class Nguoi
    {
        string HT_NguyenVu;
        DateTime NS_NguyenVu;

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin: ");
            Console.WriteLine("Nhap ho ten: ");
            HT_NguyenVu = Console.ReadLine();
            try
            {
                Console.WriteLine("Nhap ngay sinh: ");
                NS_NguyenVu = Convert.ToDateTime(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thong tin: ");
            Console.WriteLine("Ho ten: {0}", this.HT_NguyenVu);
            Console.WriteLine("Ngay sinh: {0}", this.NS_NguyenVu);
        }
    }
}
