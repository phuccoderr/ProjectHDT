using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHDT
{
    internal class PhongBan
    {
        private List<NhanVien> dsNV = new List<NhanVien>();
        public int maPhongBan { get; set; }
        public string tenPhongBan { get; set; }
        public NhanVien truongPhong { get; set; }
        public bool ThemNV(NhanVien nv)
        {
            bool trungMaNV = false;
            foreach(NhanVien oldNV in dsNV)
            {
                if(oldNV.maNhanVien == nv.maNhanVien )
                {
                    trungMaNV = true;
                    Console.WriteLine("trung nhan vien roi");
                    break;
                }
            }
            if ( trungMaNV == true ) 
            {

                return false;
            }
            nv.Phong = this;
            dsNV.Add(nv);
            return true;
        }
        public void xuatNV()
        {
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien timNV(int manv)
        {
            foreach (NhanVien old in dsNV) 
            {
                if(old.maNhanVien == manv)
                {
                    return old;
                }
                
            }
            return null;
        }
        public bool xoaNV(int manv)
        {
            NhanVien nv = timNV(manv);
            if (nv == null)
            {
                return false;
            }
            dsNV.Remove(nv);
            return true;
        }
        private static int compare(NhanVien nv1, NhanVien nv2 )
        {
            int kqss =string.Compare(nv1.tenNhanVien, nv2.tenNhanVien);
            if (kqss == 0)
            {
                if(nv2.maNhanVien > nv1.maNhanVien)
                {
                    return 1;
                }
                if (nv2.maNhanVien < nv1.maNhanVien)
                {
                    return -1;
                }
                return 0;
            }
            return kqss;
        }
        public void sapxep()
        {
            dsNV.Sort(compare);
        }
        public long tongLuong()
        {
            long sum = 0;
            foreach (NhanVien nv in dsNV) 
            {
                sum += nv.TinhLuong;
            }
            return sum;
        }
    }
}
