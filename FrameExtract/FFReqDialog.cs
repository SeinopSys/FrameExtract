using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameExtract {
	public partial class FFReqDialog : Form {
		public FFReqDialog() {
			InitializeComponent();

			this.CancelButton = exitbtn;
		}

		private void exitbtn_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void browseto_Click(object sender, EventArgs e) {
			Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
			Process.Start("http://ffmpeg.zeranoe.com/builds/");
		}
	}
}
