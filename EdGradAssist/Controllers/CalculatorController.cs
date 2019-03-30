using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EdGradAssist.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public int SomeCalculation()
		{
			int iToReturn = 0;

			return iToReturn;
		}//end SomeCalculation;
    }
}