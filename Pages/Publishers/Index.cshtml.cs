using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alexandru_Ionut_Lab2.Data;
using Alexandru_Ionut_Lab2.Models;

namespace Alexandru_Ionut_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Alexandru_Ionut_Lab2.Data.Alexandru_Ionut_Lab2Context _context;

        public IndexModel(Alexandru_Ionut_Lab2.Data.Alexandru_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
