using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameExtract {
	static class Program {
		private static MainForm mf;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mf = new MainForm();
			Application.Run(mf);
			AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
		}
		static void CurrentDomain_ProcessExit(object sender, EventArgs e){
			mf.MainForm_FormClosing();
		}
	}
}
