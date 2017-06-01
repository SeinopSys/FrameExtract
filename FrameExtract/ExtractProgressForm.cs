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
	public partial class ExtractProgressForm : OwnerDisablingForm {
		public ExtractProgressForm() {
			InitializeComponent();

			CancelButton = cancelbtn;
		}

		public void AppendText(string text){
			try {
				if (text.StartsWith("Press [q]")) {
					commandOutput.SelectionStart = commandOutput.TextLength;
					commandOutput.SelectionLength = 0;
					commandOutput.SelectionColor = Color.LimeGreen;
					commandOutput.AppendText("\nExtracting started.\n");
					commandOutput.SelectionColor = commandOutput.ForeColor;
					return;
				}
				else if (text.StartsWith("Finished")) {
					commandOutput.SelectionStart = commandOutput.TextLength;
					commandOutput.SelectionLength = 0;
					commandOutput.SelectionColor = Color.GreenYellow;
					commandOutput.AppendText(text);
					commandOutput.SelectionColor = commandOutput.ForeColor;
					return;
				}

				if (text != "\n")
					text += "\n";
				commandOutput.AppendText(text);
			}
			catch (ObjectDisposedException) {
			}
		}

		public void DisableCancel(){
			cancelbtn.Enabled = false;
			extprogress.Style = ProgressBarStyle.Continuous;
			extprogress.Increment(100);
		}

		private void cancelbtn_Click(object sender, EventArgs e) {
			this.Hide();
			this.Close();
		}
	}
}
