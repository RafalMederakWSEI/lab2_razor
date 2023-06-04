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
    public class DetailsModel : PageModel
    {
        private readonly lab2_razor.Data.lab2_razorContext _context;

        public DetailsModel(lab2_razor.Data.lab2_razorContext context)
        {
            _context = context;
        }

      public Post Post { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Post == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            else 
            {
                Post = post;
            }
            return Page();
        }
    }
}
