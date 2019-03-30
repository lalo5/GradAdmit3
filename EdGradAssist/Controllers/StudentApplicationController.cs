using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdGradAssist.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdGradAssist.Controllers
{
    public class StudentApplicationController : Controller
    {
		private readonly masterContext _context;

		public StudentApplicationController(masterContext context)
		{
			_context = context;
		}

		//public IActionResult Index()
  //      {
  //          return View();
  //      }

		public async Task<IActionResult> Index()
		{
		    return View();
		}


	}
}