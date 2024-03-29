﻿using DienTu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace DienTu.ViewComponents
{
    public class UserNameViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public UserNameViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var userFromDb = await _db.ApplicationUser.Where(a => a.Id == claim.Value).FirstOrDefaultAsync();

            return View(userFromDb);
        }
    }
}
