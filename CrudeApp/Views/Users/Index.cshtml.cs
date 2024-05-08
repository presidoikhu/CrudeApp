using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudeApp.Data;
using CrudeApp.Models;

namespace CrudeApp.Views.Users
{
    public class IndexModel : PageModel
    {
        private readonly CrudeApp.Data.CrudeAppContext _context;

        public IndexModel(CrudeApp.Data.CrudeAppContext context)
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
