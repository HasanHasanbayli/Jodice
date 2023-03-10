﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recruitment.DAL;
using Recruitment.Models;

namespace Recruitment.ViewComponents;

public class HeaderViewComponent : ViewComponent
{
    private readonly AppDbContext _db;
    private readonly UserManager<AppUser> _userManager;

    public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        Bio model = _db.Bios.FirstOrDefault();
        ViewBag.FullName = "";
        if (User.Identity.IsAuthenticated)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.User = user;
        }

        return View(await Task.FromResult(model));
    }
}