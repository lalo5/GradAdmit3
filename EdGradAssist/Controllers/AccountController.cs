using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EdGradAssist.Models.Entities;

namespace EdGradAssist.Controllers
{
    public class AccountController : Controller
    {
        private readonly masterContext _context;

        public AccountController(masterContext context)
        {
            _context = context;
        }

		public IActionResult Login()
		{
			return View();
		}

		public ActionResult Validate(Gauser gauser)
		{

			var _gauser = _context.Gauser.Where(_context => _context.Useremail == gauser.Useremail);
			if (_gauser.Any())
			{
				if (_gauser.Where(_context => _context.UserPassword == gauser.UserPassword).Any())
				{
					return Json(new { status = true, message = "Login Successfull" });
				}
				else
				{
					return Json(new { status = true, message = "Invalid Password" });
				}

			}
			else
			{
				return Json(new { status = true, message = "Invalid Email" });
			}
		}

		// GET: Account
		public async Task<IActionResult> Index()
        {
            return View(await _context.Gauser.ToListAsync());
        }

        // GET: Account/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gauser = await _context.Gauser
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (gauser == null)
            {
                return NotFound();
            }

            return View(gauser);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Useremail,UserPassword,UserType,UserStatus")] Gauser gauser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gauser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gauser);
        }

        // GET: Account/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gauser = await _context.Gauser.FindAsync(id);
            if (gauser == null)
            {
                return NotFound();
            }
            return View(gauser);
        }

        // POST: Account/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Useremail,UserPassword,UserType,UserStatus")] Gauser gauser)
        {
            if (id != gauser.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gauser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GauserExists(gauser.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gauser);
        }

        // GET: Account/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gauser = await _context.Gauser
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (gauser == null)
            {
                return NotFound();
            }

            return View(gauser);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gauser = await _context.Gauser.FindAsync(id);
            _context.Gauser.Remove(gauser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GauserExists(int id)
        {
            return _context.Gauser.Any(e => e.UserId == id);
        }
    }
}
