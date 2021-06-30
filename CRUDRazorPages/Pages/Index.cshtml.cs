using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDbConnection _connection;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            IDbConnection connection,
            ILogger<IndexModel> logger)
        {
            _connection = connection;
            _logger = logger;
        }

        public List<Customers> Customers { get; set; }

        public void OnGet()
        {

        }
    }
}
