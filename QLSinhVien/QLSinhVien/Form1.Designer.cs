namespace QLSinhVien
{
	partial class frmSignin
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
			this.ptSignIn = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cboClass = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptSignIn)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ptSignIn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 716);
			this.panel1.TabIndex = 0;
			// 
			// ptSignIn
			// 
			this.ptSignIn.Location = new System.Drawing.Point(41, 84);
			this.ptSignIn.Name = "ptSignIn";
			this.ptSignIn.Size = new System.Drawing.Size(120, 120);
			this.ptSignIn.TabIndex = 1;
			this.ptSignIn.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(895, 70);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnExit);
			this.panel3.Controls.Add(this.btnLogin);
			this.panel3.Controls.Add(this.txbPassword);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txbUserName);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(200, 70);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(895, 200);
			this.panel3.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(153, 143);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(109, 35);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(27, 143);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(109, 35);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txbPassword
			// 
			this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPassword.Location = new System.Drawing.Point(6, 100);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.PasswordChar = '*';
			this.txbPassword.Size = new System.Drawing.Size(287, 26);
			this.txbPassword.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mật khẩu:";
			// 
			// txbUserName
			// 
			this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbUserName.Location = new System.Drawing.Point(6, 38);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(287, 26);
			this.txbUserName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tài khoản:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.cboClass);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(200, 270);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(895, 446);
			this.panel4.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(254, 376);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(60, 20);
			this.label15.TabIndex = 21;
			this.label15.Text = "label15";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(77, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Thông tin cá nhân";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(254, 310);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 20);
			this.label14.TabIndex = 20;
			this.label14.Text = "label14";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(182, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Họ tên";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(254, 236);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 20);
			this.label13.TabIndex = 19;
			this.label13.Text = "label13";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(161, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Ngày sinh";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(254, 170);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "label12";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(172, 236);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 20);
			this.label8.TabIndex = 14;
			this.label8.Text = "Giới tính";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(254, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 20);
			this.label11.TabIndex = 17;
			this.label11.Text = "label11";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(182, 310);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Địa chỉ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(137, 376);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 20);
			this.label10.TabIndex = 16;
			this.label10.Text = "Số điện thoại";
			// 
			// cboClass
			// 
			this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboClass.FormattingEnabled = true;
			this.cboClass.Location = new System.Drawing.Point(508, 108);
			this.cboClass.Name = "cboClass";
			this.cboClass.Size = new System.Drawing.Size(252, 28);
			this.cboClass.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(469, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 22;
			this.label4.Text = "Chọn lớp";
			// 
			// frmSignin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(1095, 716);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmSignin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignin_FormClosing);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptSignIn)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox ptSignIn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboClass;
		private System.Windows.Forms.Label label4;
	}
}

