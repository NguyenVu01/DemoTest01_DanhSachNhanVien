using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest01
{
    internal class NhanVien : Nguoi
    {
        private string MaNV;
        private string ChucVu;
        private string PhongBan;
        private float HeSoLuong;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.WriteLine("Nhap phong ban: ");
            PhongBan = Console.ReadLine();
            while(this.HeSoLuong <= 0)
            {
                Console.WriteLine("Nhap he so luong: ");
                HeSoLuong = Convert.ToSingle(Console.ReadLine());
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien: {0}", this.MaNV);
            Console.WriteLine("Chuc vu: {0}", this.ChucVu);
            Console.WriteLine("Phong ban: {0}", this.PhongBan);
            Console.WriteLine("He so luong: {0}", this.HeSoLuong);
            Console.WriteLine("Luong nhan vien: {0}", this.TinhLuong());
            Console.WriteLine("\n");
        }

        public float TinhLuong()
        {
            if (string.Compare(this.ChucVu,"Truong phong", true) == 0 || 
                string.Compare(this.ChucVu, "truongphong", true) == 0)
                return this.HeSoLuong * 1150000 + 500000;
            else
                return this.HeSoLuong * 1150000;
        }
    }
}
