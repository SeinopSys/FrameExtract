namespace FrameExtract {
	partial class FFReqDialog {
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
			this.label1 = new System.Windows.Forms.Label();
			this.exitbtn = new System.Windows.Forms.Button();
			this.browseto = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "This application requires FFmpeg to run, and the executable could not be found. W" +
    "hat would you like to do?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// exitbtn
			// 
			this.exitbtn.Location = new System.Drawing.Point(213, 80);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(55, 23);
			this.exitbtn.TabIndex = 1;
			this.exitbtn.Text = "Exit";
			this.exitbtn.UseVisualStyleBackColor = true;
			this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
			// 
			// browseto
			// 
			this.browseto.Location = new System.Drawing.Point(66, 80);
			this.browseto.Name = "browseto";
			this.browseto.Size = new System.Drawing.Size(141, 23);
			this.browseto.TabIndex = 3;
			this.browseto.Text = "Browse to the executable";
			this.browseto.UseVisualStyleBackColor = true;
			this.browseto.Click += new System.EventHandler(this.browseto_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.Location = new System.Drawing.Point(12, 51);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(311, 16);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Visit the FFmpeg Windows binary download page";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// FFReqDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 119);
			this.ControlBox = false;
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.browseto);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FFReqDialog";
			this.ShowInTaskbar = false;
			this.Text = "Missing dependency";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button browseto;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}