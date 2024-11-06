using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portafolio.Views.Home
{
    public class _Presentacion : PageModel
    {
        private readonly ILogger<_Presentacion> _logger;

        public _Presentacion(ILogger<_Presentacion> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}