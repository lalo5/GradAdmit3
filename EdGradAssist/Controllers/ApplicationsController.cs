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
    public class ApplicationsController : Controller
    {
        private readonly masterContext _context;

        public ApplicationsController(masterContext context)
        {
            _context = context;
        }

        // GET: Applications
        public async Task<IActionResult> Index()
        {
            var masterContext = _context.Application.Include(a => a.Concentration).Include(a => a.EnumNavigation).Include(a => a.Job);
            return View(await masterContext.ToListAsync());
        }

		//public async Task<IActionResult> Index(int? id)
		//{
		//	var masterContext = _context.Application.Include(a => a.Concentration).Include(a => a.EnumNavigation).Include(a => a.Job);

		//	var model = new StudentApplicationViewModel { };

		//	return View(model);
		//}

        // GET: Applications/Details/5
        public async Task<IActionResult> Details(String id)
        {
            if (id == null)
            {
                return NotFound();
            }

			//var application = await _context.Application
			//    .Include(a => a.Concentration)
			//    .Include(a => a.EnumNavigation)
			//    .Include(a => a.Job)
			//    .FirstOrDefaultAsync(m => m.Enum == id);
			//if (application == null)
			//{
			//    return NotFound();
			//}

			ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId");
			ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum");
			ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId");


			//return View(application);
			return View();
        }

        // GET: Applications/Create
        public IActionResult Create()
        {
            ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId");
            ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum");
            ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId");
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FolderNum,ApplicationDate,Enum,ConcentrationId,JobId")] Application application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId", application.ConcentrationId);
            ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum", application.Enum);
            ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId", application.JobId);
            return View(application);
        }

        // GET: Applications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId", application.ConcentrationId);
            ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum", application.Enum);
            ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId", application.JobId);
            ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId", application.JobId);
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FolderNum,ApplicationDate,Enum,ConcentrationId,JobId")] Application application)
        {
            if (id != application.FolderNum)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.FolderNum))
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
            ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId", application.ConcentrationId);
            ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum", application.Enum);
            ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId", application.JobId);
            return View(application);
        }

        // GET: Applications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application
                .Include(a => a.Concentration)
                .Include(a => a.EnumNavigation)
                .Include(a => a.Job)
                .FirstOrDefaultAsync(m => m.FolderNum == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Application.FindAsync(id);
            _context.Application.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Application.Any(e => e.FolderNum == id);
        }

		// GET: Applications/Review/5
		public async Task<IActionResult> Review(String id)
		{
			if (id == null)
			{
				return NotFound();
			}

			//var application = await _context.Application
			//    .Include(a => a.Concentration)
			//    .Include(a => a.EnumNavigation)
			//    .Include(a => a.Job)
			//    .FirstOrDefaultAsync(m => m.Enum == id);
			//if (application == null)
			//{
			//    return NotFound();
			//}

			ViewData["ConcentrationId"] = new SelectList(_context.Concentration, "ConcentrationId", "ConcentrationId");
			ViewData["Enum"] = new SelectList(_context.Student, "Enum", "Enum");
			ViewData["JobId"] = new SelectList(_context.Job, "JobId", "JobId");


			//return View(application);
			return View();
		}
	}
}
