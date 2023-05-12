using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LQ.Basic.Web.Pages;

[Authorize]
public class IndexModel : BasicPageModel
{
    [BindProperty]
    public List<Claim> Claims { get; set; }
    public void OnGet()
    {
        Claims = HttpContext.User.Claims.ToList();

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
