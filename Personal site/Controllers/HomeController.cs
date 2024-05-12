using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Personal_site.Models;
using System;
using System.Diagnostics;



namespace Personal_site.Controllers
{
	public class HomeController : Controller
	{
		

		public HomeController()
		{
			
		}
	
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Contact()
		{
			var model = new Contact();
			return View(model);
		}
		//[HttpPost]
		//public JsonResult Contact(IFormCollection form)
		//{
		//	return Json(Ok());
		//}

		[HttpPost]
		public IActionResult Contact(Contact model)
		{

			//if(ModelState.IsValid==false) { }
			if(!ModelState.IsValid)
			{
				ViewBag.error = "لطفا اطلاعات وارد شده را بررسی کنید ";
				return View(model);
			}
			ViewBag.success = "نظرشما با موفقیت ثبت شد ";
			return View();
			//return RedirectToAction("Index");
			
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
