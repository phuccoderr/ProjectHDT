using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHDT
{
    internal class Program
    {   
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TestCN()
        {
            PhongBan pns = new PhongBan();
            pns.maPhongBan = 1;
            pns.tenPhongBan = "Phong Nhan Su";
            dsPB.Add(pns);

            NhanVien teo = new NhanVien();
            teo.maNhanVien= 0;
            teo.tenNhanVien = "Teo0";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pns.ThemNV(teo);

            NhanVien teo1 = new NhanVien();
            teo1.maNhanVien = 1;
            teo1.tenNhanVien = "Teo";
            teo1.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pns.ThemNV(teo1);

            NhanVien ty = new NhanVien();
            ty.maNhanVien = 2;
            ty.tenNhanVien = "Ti";
            ty.ChucVu = LoaiChucVu.NHAN_VIEN;
            pns.ThemNV(ty);

            PhongBan pkt = new PhongBan();
            pkt.maPhongBan = 2;
            pkt.tenPhongBan = "phong ke toan";
            dsPB.Add(pkt);
            NhanVien bin = new NhanVien();
            bin.maNhanVien = 3;
            bin.tenNhanVien = "bin dep trai";
            bin.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNV(bin);
            //tim nhan vien
            NhanVien old = pns.timNV(2);
            if (old != null)
            {
                Console.WriteLine(old.tenNhanVien);

            } else
            {
                Console.WriteLine("khong co");
            }
            //xoa nhan vien
            //pns.xoaNV(2);
            

            foreach(PhongBan pb in dsPB) 
            {
                Console.WriteLine(pb.tenPhongBan);
                pb.xuatNV();
            }

            pns.sapxep();
            Console.WriteLine("danh sach nhan vien sau khi sap xep");
            pns.xuatNV();

            Console.WriteLine("Tong luong cua cong ty trong 1 thang la");
            long sum = 0;
            foreach(PhongBan pb in dsPB)
            {
                sum += pb.tongLuong();

            }
            Console.WriteLine(sum);





        }
        static void Main(string[] args)
        {
            TestCN();
            Console.ReadLine();
        }
    }
}
