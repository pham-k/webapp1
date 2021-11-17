using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XL;

namespace MyApp.Namespace
{
    public class MH_2Model : PageModel
    {
        [BindProperty]
        public string Ten { get; set; }
        [BindProperty]
        public int Gia { get; set; }
        [BindProperty]
        public Nullable<DateTime> HanDung { get; set; }
        [BindProperty]
        public string Loai { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            // Console.WriteLine(Ten);
            XL_MH_2.TaoSanPham(Ten, Gia, HanDung, Loai);
        }
    }
}
