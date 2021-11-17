using System;
using DTO;
using DAL;

namespace XL
{
    public class XL_MH_2
    {
        public static void TaoSanPham(
            string Ten = "",
            int Gia = 0,
            Nullable<DateTime> HanDung = null,
            string Loai = "")
        {
            // Console.WriteLine(Gia);
            SP sp;
            sp.Ten = Ten;
            sp.Gia = Gia;
            sp.HanDung = HanDung;
            sp.Loai = Loai;
            SP_DAL.ThemSanPham(sp);
        }
    }
}