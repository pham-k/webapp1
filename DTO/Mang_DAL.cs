using System;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class Mang_DAL
    {
        public static int[] DocMangSoNguyen(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "./DAL/b.txt";
            }
            StreamReader file = new StreamReader(path);
            string text = file.ReadToEnd();
            file.Close();
            string[] txtArr = text.Split(",");
            int N = txtArr.Length;
            int[] ketQua = new int[N];

            for (int i = 0; i < N; i++)
            {
                ketQua[i] = int.Parse(txtArr[i]);
            }
            return ketQua;
        }
    }
}