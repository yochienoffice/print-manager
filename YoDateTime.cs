using System;

namespace YoEaseReport
{
	public class YoDateTime
	{
		public string Year { get; set; }
		public string Month { get; set; }
		public string Day { get; set; }

		public YoDateTime()
		{
			this.Year = DateTime.Now.Year.ToString();
			this.Month = DateTime.Now.Month.ToString();
			this.Day = DateTime.Now.Day.ToString();
		}
	}
}
