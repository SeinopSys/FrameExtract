using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameExtract {
	public class CommandRunner {
		private string _fname;
		private string _args;

		public string debugCommand {
			get { return _fname + " " + _args; }
		}

		private StreamReader _stdout, _stderr;

		public StreamReader Stdout => _stdout;
		public StreamReader Stderr => _stderr;
		public Process Proc { get; }

		public CommandRunner(string fname, string args = "", bool autostart = true){
			_fname = fname;
			_args = args;

			if (!_fileExists())
				throw new FileNotFoundException(fname + " cannot be found");

			Proc = new Process();
			Proc.StartInfo.RedirectStandardOutput = true;
			Proc.StartInfo.RedirectStandardError = true;
			Proc.StartInfo.FileName = _fname;
			if (_args.Length > 0)
				Proc.StartInfo.Arguments = _args;
			Proc.StartInfo.UseShellExecute = false;
			Proc.StartInfo.CreateNoWindow = true;
			if (autostart)
				Start();
		}

		public void Start(bool bindStreams = true){
			Proc.Start();
			Proc.EnableRaisingEvents = true;
			if (bindStreams) {
				_stdout = Proc.StandardOutput;
				_stderr = Proc.StandardError;
			}
		}

		private bool _fileExists(){
			if (File.Exists(_fname))
				return true;

			var values = Environment.GetEnvironmentVariable("PATH");
			foreach (var path in values.Split(';')) {
				var fullPath = Path.Combine(path, _fname);
				if (File.Exists(fullPath) || File.Exists(fullPath+".exe"))
					return true;
			}
			return false;
		}
	}
}
