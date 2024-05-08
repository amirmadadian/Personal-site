using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
namespace Personal_site.Controllers
{
	public class Test : Controller
	{
		//partila view result (for add a piece of view ) 

		//public IActionResult Index()
		//{
		//	return PartialView("Footer");
		//}

		//-----------------------------------------

		//	public PartialViewResult Index()
		//	{
		//		return PartialView("Footer");
		//	}

		//end oartial view result /

		//----------------------------------------

		//content result (for return an html code into controoler 

		// start

		//public ContentResult Index ()
		//{
		//	//return Content(" <h1> hello asp.net mvc");
		// //return Content(" <h1> hello asp.net mvc </h1>", "text/Html");
		//	return Content("<script> Confirm('this is my question?')</script>");

		//}

		//end
		//-------------------------------------------------------------------------------

		//empty result

		//public EmptyResult Index()
		//{
		//	//return  new EmptyResult();
		//	//return null;
		//}

		//-----------------------------------

		//file result 

		//public FileResult Index()
		//{
		//	//return File("~/test.txt", "text/html");
		//	var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
		//	const string filename = "testFile.txt";
		//	return File(fileByte, MediaTypeNames.Text.Plain, filename);
		//}

		//----------------------------------------

		//json result

		//public JsonResult Index()
		//{
		//	return Json(new { 
		//		id = 12, 
		//		name = "amir hossein",
		//		job = "electrical engineer & programmer"
		//	});
		//}

		//end json

		public javascriptresult Index()
		{
			return new javascriptresult("alert('bienvnue')");
		}
	}

	public class javascriptresult :ContentResult
	{
		public javascriptresult(string data)
		{
			Content = data;
			ContentType = "application/javascript";
		}
	}
}
