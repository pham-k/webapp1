using System;
using System.IO;
using Newtonsoft.Json;
using DTO;
using System.Collections.Generic;

namespace DAL
{
    public class SP_DAL
    {
        public static void LuuDSSanPham(List<SP> dsSP)
        {
            // string path = "/home/kyo/Documents/learning/cntt/ky-thuat-lap-trinh/webapp1/DAL/sp.json";
            string path = "./DAL/sp.json";
            StreamWriter file = new StreamWriter(path);
            string jsonText = JsonConvert.SerializeObject(dsSP);
            file.Write(jsonText);
            file.Close();
        }

        public static List<SP> DocDSSanPham()
        {
            // string path = "/home/kyo/Documents/learning/cntt/ky-thuat-lap-trinh/webapp1/DAL/sp.json";
            string path = "./DAL/sp.json";
            StreamReader file = new StreamReader(path);
            string jsonText = file.ReadToEnd();
            List<SP> dsSP = JsonConvert.DeserializeObject<List<SP>>(jsonText);
            file.Close();
            return dsSP;
        }

        public static void ThemSanPham(SP sp)
        {
            // Console.WriteLine(sp.Loai);
            var dsSP = DocDSSanPham();
            dsSP.Add(sp);
            LuuDSSanPham(dsSP);
        }
    }
}
