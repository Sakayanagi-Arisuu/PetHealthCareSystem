using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetHealthCareSystem.Repositories.Entities;

namespace PetHealthCareSystem.WebApplication.Pages.UserPage
{
    public class DetailsModel : PageModel
    {
        private readonly PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext _context;

        public DetailsModel(PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.UserId == id);

            if (user is not null)
            {
                User = user;

                return Page();
            }

            return NotFound();
        }
    }
}
