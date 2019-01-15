﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public string NameKey { get; set; }

        public void OnGet(string nameKey)
        {
            NameKey = nameKey;
        }
    }
}