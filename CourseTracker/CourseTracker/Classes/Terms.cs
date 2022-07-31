using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTracker.Classes
{
	public class Terms
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
