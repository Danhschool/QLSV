namespace QLSinhVien
{
	partial class fTableManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnScore = new System.Windows.Forms.Button();
			this.btnStudent = new System.Windows.Forms.Button();
			this.btnHomePage = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ptbLogo = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnMain = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnScore);
			this.panel1.Controls.Add(this.btnStudent);
			this.panel1.Controls.Add(this.btnHomePage);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(282, 814);
			this.panel1.TabIndex = 0;
			// 
			// btnScore
			// 
			this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnScore.Location = new System.Drawing.Point(12, 300);
			this.btnScore.Name = "btnScore";
			this.btnScore.Size = new System.Drawing.Size(254, 53);
			this.btnScore.TabIndex = 5;
			this.btnScore.Text = "Điểm số";
			this.btnScore.UseVisualStyleBackColor = true;
			this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
			// 
			// btnStudent
			// 
			this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStudent.Location = new System.Drawing.Point(12, 216);
			this.btnStudent.Name = "btnStudent";
			this.btnStudent.Size = new System.Drawing.Size(254, 53);
			this.btnStudent.TabIndex = 3;
			this.btnStudent.Text = "Sinh viên";
			this.btnStudent.UseVisualStyleBackColor = true;
			this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
			// 
			// btnHomePage
			// 
			this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHomePage.Location = new System.Drawing.Point(12, 134);
			this.btnHomePage.Name = "btnHomePage";
			this.btnHomePage.Size = new System.Drawing.Size(254, 53);
			this.btnHomePage.TabIndex = 2;
			this.btnHomePage.Text = "Trang chủ";
			this.btnHomePage.UseVisualStyleBackColor = true;
			this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quản lý";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ptbLogo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(282, 65);
			this.panel2.TabIndex = 0;
			// 
			// ptbLogo
			// 
			this.ptbLogo.Location = new System.Drawing.Point(56, 3);
			this.ptbLogo.Name = "ptbLogo";
			this.ptbLogo.Size = new System.Drawing.Size(172, 50);
			this.ptbLogo.TabIndex = 0;
			this.ptbLogo.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(282, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1525, 65);
			this.panel4.TabIndex = 2;
			// 
			// pnMain
			// 
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(282, 65);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1525, 749);
			this.pnMain.TabIndex = 3;
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1807, 814);
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "fTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fTableManager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnHomePage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox ptbLogo;
		private System.Windows.Forms.Button btnStudent;
		private System.Windows.Forms.Button btnScore;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel pnMain;
	}
}