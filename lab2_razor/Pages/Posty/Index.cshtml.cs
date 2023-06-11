using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab2_razor.Data;
using lab2_razor.Pages.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var posts = from p in _context.Post
                         select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                posts = posts.Where(s => s.Title.Contains(SearchString));
            }

            Post = await posts.ToListAsync();

            //if (_context.Post != null)
            //{
            //    Post = await _context.Post.ToListAsync();
            //}
        }
    }
}
