using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using realestateAndrea.Data;
using realestateAndrea.Model;

namespace realestateAndrea.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly realestateAndrea.Data.realestateAndreaContext _context;

        public IndexModel(realestateAndrea.Data.realestateAndreaContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
