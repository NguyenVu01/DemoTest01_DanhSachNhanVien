using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest01
{
    internal class DanhSachNhanVien : NhanVien
    {
        private int n; //SoLuongNhanVien
        private NhanVien[] danhSach;

        public DanhSachNhanVien(int x)
        {
            n = x;
            danhSach = new NhanVien[n];
        }

        public void NhapDS()
        {
            Console.WriteLine("--------------Bat dau nhap danh sach nhan vien----------------");
            for(int i = 0; i < danhSach.Length; i++)
            {
                Console.WriteLine("Nhap nhan vien thu {0}: ", i+1);
                danhSach[i] = new NhanVien();
                danhSach[i].Nhap();
                Console.WriteLine("\n");
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("-------------Danh sach nhan vien--------------");
            for(int i = 0; i<danhSach.Length; i++)
            {
                Console.WriteLine("Nhan vien thu {0}", i+1);
                danhSach[i].Xuat();
            }
        }

    }
}
