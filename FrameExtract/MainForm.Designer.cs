namespace FrameExtract {
	partial class MainForm {
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
			this.ffpathin = new System.Windows.Forms.TextBox();
			this.ffbtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.infilein = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.infilebtn = new System.Windows.Forms.Button();
			this.extractbtn = new System.Windows.Forms.Button();
			this.outfilebtn = new System.Windows.Forms.Button();
			this.outfilein = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tsin = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Path to ffmpeg.exe";
			// 
			// ffpathin
			// 
			this.ffpathin.BackColor = System.Drawing.Color.MistyRose;
			this.ffpathin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ffpathin.Location = new System.Drawing.Point(12, 30);
			this.ffpathin.Name = "ffpathin";
			this.ffpathin.Size = new System.Drawing.Size(196, 20);
			this.ffpathin.TabIndex = 1;
			this.ffpathin.Leave += new System.EventHandler(this.ffpathin_Leave);
			// 
			// ffbtn
			// 
			this.ffbtn.Location = new System.Drawing.Point(214, 30);
			this.ffbtn.Name = "ffbtn";
			this.ffbtn.Size = new System.Drawing.Size(58, 20);
			this.ffbtn.TabIndex = 2;
			this.ffbtn.Text = "Browse";
			this.ffbtn.UseVisualStyleBackColor = true;
			this.ffbtn.Click += new System.EventHandler(this.ffbtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Timestamp";
			// 
			// infilein
			// 
			this.infilein.BackColor = System.Drawing.Color.MistyRose;
			this.infilein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.infilein.Location = new System.Drawing.Point(12, 69);
			this.infilein.Name = "infilein";
			this.infilein.Size = new System.Drawing.Size(196, 20);
			this.infilein.TabIndex = 5;
			this.infilein.TextChanged += new System.EventHandler(this.infilein_TextChanged);
			this.infilein.Leave += new System.EventHandler(this.infilein_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Input file";
			// 
			// infilebtn
			// 
			this.infilebtn.Location = new System.Drawing.Point(214, 69);
			this.infilebtn.Name = "infilebtn";
			this.infilebtn.Size = new System.Drawing.Size(58, 20);
			this.infilebtn.TabIndex = 2;
			this.infilebtn.Text = "Browse";
			this.infilebtn.UseVisualStyleBackColor = true;
			this.infilebtn.Click += new System.EventHandler(this.infilebtn_Click);
			// 
			// extractbtn
			// 
			this.extractbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.extractbtn.Location = new System.Drawing.Point(12, 182);
			this.extractbtn.Name = "extractbtn";
			this.extractbtn.Size = new System.Drawing.Size(260, 36);
			this.extractbtn.TabIndex = 7;
			this.extractbtn.Text = "Extract";
			this.extractbtn.UseVisualStyleBackColor = true;
			this.extractbtn.Click += new System.EventHandler(this.extractbtn_Click);
			// 
			// outfilebtn
			// 
			this.outfilebtn.Location = new System.Drawing.Point(214, 156);
			this.outfilebtn.Name = "outfilebtn";
			this.outfilebtn.Size = new System.Drawing.Size(58, 20);
			this.outfilebtn.TabIndex = 2;
			this.outfilebtn.Text = "Browse";
			this.outfilebtn.UseVisualStyleBackColor = true;
			this.outfilebtn.Click += new System.EventHandler(this.outfilebtn_Click);
			this.outfilebtn.Leave += new System.EventHandler(this.outfilein_Leave);
			// 
			// outfilein
			// 
			this.outfilein.BackColor = System.Drawing.Color.MistyRose;
			this.outfilein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.outfilein.Location = new System.Drawing.Point(12, 156);
			this.outfilein.Name = "outfilein";
			this.outfilein.Size = new System.Drawing.Size(196, 20);
			this.outfilein.TabIndex = 5;
			this.outfilein.TextChanged += new System.EventHandler(this.outfilein_TextChanged);
			this.outfilein.Leave += new System.EventHandler(this.outfilein_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Output file (%t will be replaced by the timestamp)";
			// 
			// tsin
			// 
			this.tsin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tsin.Location = new System.Drawing.Point(12, 108);
			this.tsin.Mask = "00:00:00\\.000";
			this.tsin.Name = "tsin";
			this.tsin.PromptChar = '0';
			this.tsin.Size = new System.Drawing.Size(260, 29);
			this.tsin.TabIndex = 8;
			this.tsin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 230);
			this.Controls.Add(this.tsin);
			this.Controls.Add(this.extractbtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.outfilein);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.infilein);
			this.Controls.Add(this.outfilebtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.infilebtn);
			this.Controls.Add(this.ffbtn);
			this.Controls.Add(this.ffpathin);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "FrameExtract";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ffpathin;
		private System.Windows.Forms.Button ffbtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox infilein;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button infilebtn;
		private System.Windows.Forms.Button extractbtn;
		private System.Windows.Forms.Button outfilebtn;
		private System.Windows.Forms.TextBox outfilein;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox tsin;
	}
}

