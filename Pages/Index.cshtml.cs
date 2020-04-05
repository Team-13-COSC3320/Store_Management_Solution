using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Store_Management.Models;

namespace Store_Management.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet =true)]
        public string U_LastName { set; get; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(U_LastName))
            {
                U_LastName = "to Cougar Car";
            }
        }
    }
}
