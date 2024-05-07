using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Personal_site.Models;

namespace Personal_site.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1,"سپیدار","  مدیریت منابع ومتریال از پروژه های عظیم تا فروشگاه کوچک ","project-5.jpg","Sepidar"),
				new Project(2,"پارسی برق","  طراحی و ساخت تابلو های کنترلی و قدرت برای پروژه ها و اجرای پروزه ها ","IMG_20230930_113226.jpg","ParsiBragh"),
				new Project(3,"سپ دات نت","  برنامه نویسی حوزه وب ","project-4.jpg","Sepidar"),
				new Project(4,"پروژه ها","  خدمات مهندسی و طراحی وپیاده سازی پروژه های تجاری و مسکونی  ","1635690464254.jpeg","ParsiBargh"),
			};
			return View("_Projects",projects);
		}
	}
}
