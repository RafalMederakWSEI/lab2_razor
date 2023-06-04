using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab2_razor.Data;
using lab2_razor.Pages.Models;

namespace lab2_razor.Pages.Posty
{
    public class IndexModel : PageModel
    {
        private readonly lab2_razor.Data.lab2_razorContext _context;

        public IndexModel(lab2_razor.Data.lab2_razorContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Post != null)
            {
                Post = await _context.Post.ToListAsync();
            }
        }
    }
}
