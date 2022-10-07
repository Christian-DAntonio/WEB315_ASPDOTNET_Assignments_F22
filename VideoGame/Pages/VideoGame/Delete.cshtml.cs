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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesVideoGameContext _context;

        public DeleteModel(RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        [BindProperty]
      public VideoGame VideoGame { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VideoGame == null)
            {
                return NotFound();
            }

            var videogame = await _context.VideoGame.FirstOrDefaultAsync(m => m.ID == id);

            if (videogame == null)
            {
                return NotFound();
            }
            else 
            {
                VideoGame = videogame;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VideoGame == null)
            {
                return NotFound();
            }
            var videogame = await _context.VideoGame.FindAsync(id);

            if (videogame != null)
            {
                VideoGame = videogame;
                _context.VideoGame.Remove(VideoGame);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
