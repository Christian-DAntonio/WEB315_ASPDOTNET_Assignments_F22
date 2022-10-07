using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoGame.Models;

namespace VideoGame.Pages_VideoGame
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesVideoGameContext _context;

        public IndexModel(RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VideoGame != null)
            {
                VideoGame = await _context.VideoGame.ToListAsync();
            }
        }
    }
}
