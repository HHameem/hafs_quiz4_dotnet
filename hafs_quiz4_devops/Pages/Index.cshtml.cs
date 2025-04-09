using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace hafs_quiz4_devops.Pages
{
        public class IndexModel : PageModel
        {
            public string Message { get; private set; } = string.Empty;

            public void OnGet()
            {
                Message = "Database access has already been done on April 1, 2025 by Hafshan";
            }
        }
    }
