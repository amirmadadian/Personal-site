using Microsoft.AspNetCore.Mvc;
using Personal_site.Models;
using System.Collections.Generic;

namespace Personal_site.ViewComponents
{
	public class LatestArticlesViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articles = new List<Article>
			{
				new Article(1,"آموزش BMS","ساده ترین بیان هوشمند سازی","blog_image.jpg"),
				new Article(2,"ساخت تابلو","ساخت تابلو های کنترلی","electical-panels.jpg"),
				new Article(3,"پروژه","معرفی پروژه","Tools-16.jpg"),
			};
			return View("_LatestArticles",articles);
		}

	}
}
