using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcZSGC.Models
{
	public class DataContext :DbContext
	{
		public DbSet<PUser> PUsers { get; set; }
	}
}