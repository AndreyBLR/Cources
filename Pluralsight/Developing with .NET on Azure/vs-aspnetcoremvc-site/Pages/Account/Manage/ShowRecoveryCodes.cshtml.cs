using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vs_aspnetcoremvc_site.Pages.Account.Manage
{
    public class ShowRecoveryCodesModel : PageModel
    {
        public string[] RecoveryCodes { get; private set; }

        public IActionResult OnGet()
        {
            RecoveryCodes = (string[])TempData["RecoveryCodes"];
            if (RecoveryCodes == null)
            {
                return RedirectToPage("TwoFactorAuthentication");
            }

            return Page();
        }
    }
}