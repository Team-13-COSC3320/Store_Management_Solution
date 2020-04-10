using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store_Management.Services;


namespace Store_Management
{
    public class IndexModel : PageModel
    {
        public IndexModel(IUserResposity userResposity)
        {

        }
        public void OnGet()
        {

        }
    }
}