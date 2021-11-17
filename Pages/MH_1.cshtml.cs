using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XL;

namespace MyApp.Namespace
{
    public class MH_1Model : PageModel
    {
        [BindProperty]
        public int KetQua { get; set; }
        [BindProperty]
        public int N { get; set;}
        
        public void OnGet()
        {
            N = 0;
        }
        public void OnPost()
        {

            // Response.Redirect("/");
            KetQua = XL_MH_1.TinhTong(N);
        }
    }
}
