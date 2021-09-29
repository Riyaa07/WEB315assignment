using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Food.Pages
{
    public class ControlModel : PageModel
    {
        private readonly ILogger<ControlModel> _logger;
        public DateTime todaysDate;

        public ControlModel(ILogger<ControlModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
           todaysDate = DateTime.Now;
        }
    }
}
