using System;

namespace XL
{
    public class XL_MH_1
    {
        public static int TinhTong(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    tong += i;
                }
            }
            return tong;
        }
    }
}
