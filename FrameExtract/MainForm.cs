using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameExtract.Properties;

namespace FrameExtract {
	public partial class MainForm : Form {
		private string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		private string _ffpath = "", _infilepath = "", _outfilepath = "";

		public MainForm(){
			InitializeComponent();

			Icon = Resources.logo;
			Show();

			VerifyFf("ffmpeg", false);
			VerifyOutfile(Path.Combine(_desktopPath, "snap-%t.png"));
		}

		private void ffbtn_Click(object sender, EventArgs e){
			ffbtn_Click();
		}
		private void ffbtn_Click(){
			var fd = new OpenFileDialog();
			fd.Title = "Browse to ffmpeg.exe";
			fd.CheckFileExists = true;
			fd.CheckPathExists = true;
			fd.Filter = "ffmpeg executable|ffmpeg.exe";
			DialogResult result = fd.ShowDialog();
			if (result == DialogResult.OK) {
				VerifyFf(fd.FileName);
			}
		}

		private void ffpathin_Leave(object sender, EventArgs e) {
			VerifyFf(ffpathin.Text);
		}

		private void VerifyFf(string tmpffpath, bool errorOnFail = true){
			tmpffpath = tmpffpath.Replace("\"", "");
			if (tmpffpath == _ffpath)
				return;

			var vd = new FFVerifyDialog();
			vd.Show(this);
			bool success = false;
			try {
				var ffcr = new CommandRunner(tmpffpath);
				var tmpversionInfo = ffcr.Stderr.ReadLine();
				success = tmpversionInfo != null && tmpversionInfo.StartsWith("ffmpeg version");
			}
			catch (FileNotFoundException) {}
			DialogResult res = DialogResult.None;
			if (success) {
				_ffpath = tmpffpath;
			}
			else {
				if (errorOnFail)
					res = MessageBox.Show(vd, "The specified file must point to the ffmpeg executable", "ffmpeg.exe error",
						MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
			}

			ffpathin.Text = _ffpath;
			if (ffpathin.Text.Length != 0)
				ffpathin.BackColor = SystemColors.Window;
			vd.Hide();
			Focus();
			if (!success) {
				if (!errorOnFail) {
					new FFReqDialog().ShowDialog(vd);
					res = DialogResult.Retry;
				}
				if (res == DialogResult.Retry)
					ffbtn_Click();
			}
			else infilein.Focus();
		}

		private void infilebtn_Click(object sender, EventArgs e) {
			var fd = new OpenFileDialog {
				Title = "Browse to a supported video file",
				CheckFileExists = true,
				CheckPathExists = true,
				Filter = "Video files|*.mp4;*.mkv;*.avi;*.mov;*.webm"
			};
			DialogResult result = fd.ShowDialog();
			if (result == DialogResult.OK)
				VerifyInfile(fd.FileName);
		}

		private void infilein_Leave(object sender, EventArgs e) {
			VerifyInfile(infilein.Text);
		}
		private void infilein_TextChanged(object sender, EventArgs e) {
			VerifyInfile(infilein.Text, true);
		}
		private void VerifyInfile(string fname, bool skipForce = false) {
			fname = fname.Replace("\"", "");
			if (_infilepath == fname)
				return;
			if (File.Exists(fname))
				_infilepath = fname;
			if (!skipForce)
				infilein.Text = _infilepath;
			if (infilein.Text.Length != 0)
				infilein.BackColor = SystemColors.Window;
		}

		private void outfilebtn_Click(object sender, EventArgs e){
			outfilebtn_Click();
		}
		private void outfilebtn_Click() {
			var fd = new SaveFileDialog {
				Title = "Chose the format and location of exported frame",
				CheckPathExists = true,
				CheckFileExists = false,
				AddExtension = true,
				Filter = "PNG file|*.png|Bitmap|*.bmp|JPEG file|*.jpg;*.jpeg",
				DefaultExt = "png",
				FileName = _outfilepath.Length > 0 ? Path.GetFileName(_outfilepath) : "snap-%t.png",
				InitialDirectory = _desktopPath,
			};
			DialogResult result = fd.ShowDialog();
			if (result == DialogResult.OK)
				VerifyOutfile(fd.FileName);
		}
		private void outfilein_Leave(object sender, EventArgs e) {
			VerifyOutfile(outfilein.Text);
		}

		private void outfilein_TextChanged(object sender, EventArgs e) {
			VerifyOutfile(outfilein.Text, true);
		}
		private void VerifyOutfile(string fname, bool skipForce = false) {
			fname = fname.Replace("\"", "");
			if (_outfilepath == fname)
				return;
			_outfilepath = fname;
			if (!skipForce)
				outfilein.Text = _outfilepath;
			if (outfilein.Text.Length != 0)
				outfilein.BackColor = SystemColors.Window;
		}

		private void extractbtn_Click(object sender, EventArgs e){
			Extract();
		}

		private CommandRunner _extractcr;
		private void Extract(){
			if (_infilepath.Length == 0) {
				MessageBox.Show(this, "The input file cannot be empty", "Validation error", MessageBoxButtons.OK,
					MessageBoxIcon.None);
				return;
			}
			if (_outfilepath.Length == 0) {
				MessageBox.Show(this, "The output file cannot be empty", "Validation error", MessageBoxButtons.OK,
					MessageBoxIcon.None);
				return;
			}
			File.Delete(_outfilepath);
			var exf = new ExtractProgressForm();
			exf.Show(this);
			string ts = tsin.Text.Replace(" ", "0");
			string outfile = _outfilepath.Replace("%t", ts.Replace(":", "-").Replace(".", "_"));
			_extractcr = new CommandRunner(
				_ffpath,
				"-ss " + ts + " "
				+ "-i \"" + _infilepath + "\" "
				+ "-frames:v 1 "
				+ "-hide_banner -y -sn "
				+ "\"" + outfile + "\"",
				false
			);
			_extractcr.Proc.OutputDataReceived += (object sender, DataReceivedEventArgs e) => {
				BeginInvoke(new MethodInvoker(() => {
					exf.AppendText(e.Data ?? string.Empty);
				}));
			};
			_extractcr.Proc.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => {
				BeginInvoke(new MethodInvoker(() => {
					exf.AppendText(e.Data ?? string.Empty);
				}));
			};
			_extractcr.Start(false);
			exf.AppendText("> "+_extractcr.debugCommand+"\n");
			_extractcr.Proc.BeginOutputReadLine();
			_extractcr.Proc.BeginErrorReadLine();
			_extractcr.Proc.Exited += (object sender, EventArgs e) => {
				BeginInvoke(new MethodInvoker(() => {
					exf.AppendText("Finished, close this window to extract another frame.");
					exf.FormClosing += (object _sender, FormClosingEventArgs _e) => {
						exf.Hide();
						BeginInvoke(new MethodInvoker(() => {
							Focus();
						}));
					};
					exf.ControlBox = true;
					exf.DisableCancel();
				}));
			};
			exf.FormClosing += (object sender, FormClosingEventArgs e) => {
				BeginInvoke(new MethodInvoker(() => {
					_extractcr.Proc.ErrorDataReceived += null;
					_extractcr.Proc.OutputDataReceived += null;
					if (!_extractcr.Proc.HasExited)
						_extractcr.Proc.Kill();
				}));
			};
		}

		public void MainForm_FormClosing(object sender, EventArgs e){
			MainForm_FormClosing();
		}
		public void MainForm_FormClosing(){
			if (_extractcr != null && !_extractcr.Proc.HasExited)
				_extractcr.Proc.Kill();
		}
	}
}
