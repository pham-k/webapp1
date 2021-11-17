using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XL;

namespace MyApp.Namespace
{
    public class MH_4Model : PageModel
    {
        [BindProperty]
        string DuongDan1 { get; set; }
        [BindProperty]
        string DuongDan2 { get; set; }
        [BindProperty]
        public bool KetQua { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            // KetQua = XL_MH_4.KiemTra(DuongDan1, DuongDan2);
            KetQua = XL_MH_4.KiemTra();
        }
    }
}
