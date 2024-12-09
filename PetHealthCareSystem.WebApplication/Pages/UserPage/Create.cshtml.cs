using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHealthCareSystem.Repositories.Entities;

namespace PetHealthCareSystem.WebApplication.Pages.UserPage
{
    public class CreateModel : PageModel
    {
        private readonly PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext _context;

        public CreateModel(PetHealthCareSystem.Repositories.Entities.PetHealthCareSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(User);
            await _context.Database.ExecuteSqlRawAsync("EXEC UpdateUserIDInAccount");

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
