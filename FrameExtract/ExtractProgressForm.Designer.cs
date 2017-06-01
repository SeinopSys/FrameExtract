namespace FrameExtract {
	partial class ExtractProgressForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.extprogress = new System.Windows.Forms.ProgressBar();
			this.commandOutput = new System.Windows.Forms.RichTextBox();
			this.cancelbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// extprogress
			// 
			this.extprogress.Location = new System.Drawing.Point(13, 13);
			this.extprogress.Name = "extprogress";
			this.extprogress.Size = new System.Drawing.Size(508, 23);
			this.extprogress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.extprogress.TabIndex = 0;
			// 
			// commandOutput
			// 
			this.commandOutput.BackColor = System.Drawing.Color.Black;
			this.commandOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.commandOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.commandOutput.ForeColor = System.Drawing.Color.White;
			this.commandOutput.Location = new System.Drawing.Point(13, 43);
			this.commandOutput.Name = "commandOutput";
			this.commandOutput.ReadOnly = true;
			this.commandOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.commandOutput.Size = new System.Drawing.Size(630, 276);
			this.commandOutput.TabIndex = 1;
			this.commandOutput.Text = "";
			// 
			// cancelbtn
			// 
			this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cancelbtn.ForeColor = System.Drawing.Color.DarkRed;
			this.cancelbtn.Location = new System.Drawing.Point(527, 13);
			this.cancelbtn.Name = "cancelbtn";
			this.cancelbtn.Size = new System.Drawing.Size(116, 24);
			this.cancelbtn.TabIndex = 3;
			this.cancelbtn.Text = "Cancel";
			this.cancelbtn.UseVisualStyleBackColor = true;
			this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
			// 
			// ExtractProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 331);
			this.ControlBox = false;
			this.Controls.Add(this.cancelbtn);
			this.Controls.Add(this.commandOutput);
			this.Controls.Add(this.extprogress);
			this.Name = "ExtractProgressForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Extracting frame";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar extprogress;
		private System.Windows.Forms.RichTextBox commandOutput;
		private System.Windows.Forms.Button cancelbtn;
	}
}