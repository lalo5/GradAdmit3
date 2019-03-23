using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EdGradAssist.Models;
using EdGradAssist.Models.Entities;

namespace EdGradAssist.Controllers
{
	public class HomeController : Controller
	{
		private masterContext db = new masterContext();

		public IActionResult Index()
		{
			return View();
		}




		//public ActionResult Index(string Enum)
		//{
		//	string SearchEnum = Enum;
		//	var student = from m in db
		//					  select m;

		//	if (!String.IsNullOrEmpty(SearchEnum))
		//	{
		//		student = student.Where(s => s.Enum.Contains(SearchEnum));
		//	}
		//}


		public IActionResult Application()
		{
			return View();
		}


		//public IActionResult About()
		//{
		//	ViewData["Message"] = "Your application description page.";

		//	return View();
		//}

		//public IActionResult Contact()
		//{
		//	ViewData["Message"] = "Your contact page.";

		//	return View();
		//}

		//public IActionResult Privacy()
		//{
		//	return View();
		//}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
