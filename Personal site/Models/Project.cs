using System.Security.Permissions;

namespace Personal_site.Models
{
	public class Project
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Client { get; set; }
	}
}
