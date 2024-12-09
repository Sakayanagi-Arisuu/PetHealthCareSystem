using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetHealthCareSystem.Repositories.Entities;

namespace PetHealthCareSystem.WebApplication.Pages.AccountPage
{
    public class DetailsModel : PageModel
    {
        private readonly PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext _context;

        public DetailsModel(PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext context)
        {
            _context = context;
        }

        public Account Account { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.AccountId == id);

            if (account is not null)
            {
                Account = account;

                return Page();
            }

            return NotFound();
        }
    }
}
