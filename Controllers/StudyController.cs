using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetNote.Controllers
{
	public class StudyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult	cSharp()
		{
			return View();
		}

		public IActionResult	Java()
		{
			return View(); 
		}

		public IActionResult	Cplus()
		{
			return View();
		}
	}
}
