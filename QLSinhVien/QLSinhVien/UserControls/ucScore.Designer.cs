namespace QLSinhVien.UserControls
{
	partial class ucScore
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvScore = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboSubject = new System.Windows.Forms.ComboBox();
			this.cboStudent = new System.Windows.Forms.ComboBox();
			this.txbScore = new System.Windows.Forms.TextBox();
			this.txbAVGScore = new System.Windows.Forms.TextBox();
			this.txbGPA = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvScore);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(888, 749);
			this.panel1.TabIndex = 0;
			// 
			// dgvScore
			// 
			this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvScore.Location = new System.Drawing.Point(3, 25);
			this.dgvScore.Name = "dgvScore";
			this.dgvScore.Size = new System.Drawing.Size(882, 721);
			this.dgvScore.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(952, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Chọn học phần";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(952, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Chọn học sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(952, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Điểm";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(952, 387);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(166, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Điểm trung bình học kì";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(952, 495);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Điểm trung bình khóa";
			// 
			// cboSubject
			// 
			this.cboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSubject.FormattingEnabled = true;
			this.cboSubject.Location = new System.Drawing.Point(956, 77);
			this.cboSubject.Name = "cboSubject";
			this.cboSubject.Size = new System.Drawing.Size(487, 28);
			this.cboSubject.TabIndex = 7;
			// 
			// cboStudent
			// 
			this.cboStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboStudent.FormattingEnabled = true;
			this.cboStudent.Location = new System.Drawing.Point(956, 180);
			this.cboStudent.Name = "cboStudent";
			this.cboStudent.Size = new System.Drawing.Size(487, 28);
			this.cboStudent.TabIndex = 9;
			// 
			// txbScore
			// 
			this.txbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbScore.Location = new System.Drawing.Point(956, 333);
			this.txbScore.Name = "txbScore";
			this.txbScore.Size = new System.Drawing.Size(487, 26);
			this.txbScore.TabIndex = 10;
			// 
			// txbAVGScore
			// 
			this.txbAVGScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbAVGScore.Location = new System.Drawing.Point(956, 437);
			this.txbAVGScore.Name = "txbAVGScore";
			this.txbAVGScore.Size = new System.Drawing.Size(487, 26);
			this.txbAVGScore.TabIndex = 11;
			// 
			// txbGPA
			// 
			this.txbGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbGPA.Location = new System.Drawing.Point(956, 545);
			this.txbGPA.Name = "txbGPA";
			this.txbGPA.Size = new System.Drawing.Size(487, 26);
			this.txbGPA.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(952, 227);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Ngày nhập";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(1321, 631);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(96, 40);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(1168, 631);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(96, 40);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(990, 631);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(96, 40);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Location = new System.Drawing.Point(956, 264);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(487, 26);
			this.dtpDate.TabIndex = 20;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// ucScore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbGPA);
			this.Controls.Add(this.txbAVGScore);
			this.Controls.Add(this.txbScore);
			this.Controls.Add(this.cboStudent);
			this.Controls.Add(this.cboSubject);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "ucScore";
			this.Size = new System.Drawing.Size(1525, 749);
			this.Load += new System.EventHandler(this.ucScore_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvScore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboSubject;
		private System.Windows.Forms.ComboBox cboStudent;
		private System.Windows.Forms.TextBox txbScore;
		private System.Windows.Forms.TextBox txbAVGScore;
		private System.Windows.Forms.TextBox txbGPA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DateTimePicker dtpDate;
	}
}
