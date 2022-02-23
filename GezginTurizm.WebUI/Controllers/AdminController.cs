using GezginTurizm.DataAccess.Concrete.EntityFramework;
using GezginTurizm.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.Controllers
{
    public class AdminController : Controller
    {
        GezginContext _context = new GezginContext();
        [HttpGet]
        public IActionResult Admin() => View();
        public async Task<IActionResult> Admin(Admin p)
        {
            var info = _context.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (info != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UserName),
                    new Claim("Id",info.AdminId.ToString())
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "ManagementPanel");
            }
            return View();
        }
    }
}
