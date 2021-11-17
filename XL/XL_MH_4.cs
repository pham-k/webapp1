using System;
using DAL;

namespace XL
{
    public class XL_MH_4
    {
        public static bool KiemTra(
            string duongdan1="./DAL/a.txt", string duongdan2="./DAL/b.txt"
            )
        {
            // int[] a = {1, 2, 4, 5, 1, 2, 3, 7};
            // int[] b = {5, 1, 2, 3};
            int[] a = Mang_DAL.DocMangSoNguyen(duongdan1);
            int[] b = Mang_DAL.DocMangSoNguyen(duongdan2);
            bool ketQua = false;
            for (int i = 0; i < a.Length - b.Length + 1; i++)
            {
                if (a[i] == b[0])
                {
                    ketQua = true;
                    for (int j = 1; j < b.Length; j++){
                        ketQua = ketQua & (a[i+j] == b[j]);
                    }
                }
            }
            return ketQua;

        }
    }
}