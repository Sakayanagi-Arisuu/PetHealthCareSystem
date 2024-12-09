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
    public class IndexModel : PageModel
    {
        private readonly PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext _context;

        public IndexModel(PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Account = await _context.Accounts
                .Include(a => a.User).ToListAsync();
        }
    }
}
