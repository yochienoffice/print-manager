using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace YoEaseReport
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Environment.OSVersion.Version.Major >= 6)
				SetProcessDPIAware();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormYoEaseReport());
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool SetProcessDPIAware();
	}
}
