using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHDT
{
    internal class NhanVien
    {
        public const long Luong_Co_Ban = 1000000;
        public int maNhanVien { get; set; }
        public string tenNhanVien { get; set; } 
        public DateTime ngaySinh { get; set; }
        public LoaiChucVu ChucVu { get; set; }  
        public PhongBan Phong { get; set; }
        public long TinhLuong
        {
            get
            {
                if(ChucVu == LoaiChucVu.GIAM_DOC) 
                {
                    return Luong_Co_Ban + (long)(Luong_Co_Ban * 0.25);
                }
                if (ChucVu == LoaiChucVu.TRUONG_PHONG) 
                {
                    return Luong_Co_Ban + (long)(Luong_Co_Ban * 0.15);
                }
                if (ChucVu == LoaiChucVu.PHO_PHONG)
                {
                    return Luong_Co_Ban + (long)(Luong_Co_Ban * 0.05);
                }
                return Luong_Co_Ban;
            }
        }
        public override string ToString()
        {
            return this.maNhanVien +"\n" 
                + this.tenNhanVien + "\n" 
                + this.ChucVu + "\n" 
                + this.TinhLuong;
        }

    }
}
