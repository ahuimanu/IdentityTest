using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace IdentityTest.Areas.Identity.Pages.Manage
{
    public class ShowUsersModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<ShowUsersModel> _logger;


        public IList<IdentityUser> Users { get; set; }

        public ShowUsersModel(
            UserManager<IdentityUser> userManager,
            ILogger<ShowUsersModel> logger)
        {
            _userManager = userManager;
            _logger = logger;

        }

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }
    }
}