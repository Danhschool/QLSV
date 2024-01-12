namespace QLSinhVien.UserControls
{
	partial class ucStudent
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dtpDateOdBirth = new System.Windows.Forms.DateTimePicker();
			this.cboSex = new System.Windows.Forms.ComboBox();
			this.cboClassID = new System.Windows.Forms.ComboBox();
			this.txbPhone = new System.Windows.Forms.TextBox();
			this.txbAddress = new System.Windows.Forms.TextBox();
			this.txbStudentName = new System.Windows.Forms.TextBox();
			this.txbStudentID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(914, 749);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvStudent);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 117);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(914, 632);
			this.panel2.TabIndex = 0;
			// 
			// dgvStudent
			// 
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvStudent.Location = new System.Drawing.Point(3, 3);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.Size = new System.Drawing.Size(908, 626);
			this.dgvStudent.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnDelete);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Controls.Add(this.dtpDateOdBirth);
			this.panel3.Controls.Add(this.cboSex);
			this.panel3.Controls.Add(this.cboClassID);
			this.panel3.Controls.Add(this.txbPhone);
			this.panel3.Controls.Add(this.txbAddress);
			this.panel3.Controls.Add(this.txbStudentName);
			this.panel3.Controls.Add(this.txbStudentID);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(914, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(611, 749);
			this.panel3.TabIndex = 1;
			// 
			// dtpDateOdBirth
			// 
			this.dtpDateOdBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateOdBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateOdBirth.Location = new System.Drawing.Point(73, 316);
			this.dtpDateOdBirth.Name = "dtpDateOdBirth";
			this.dtpDateOdBirth.Size = new System.Drawing.Size(489, 26);
			this.dtpDateOdBirth.TabIndex = 13;
			// 
			// cboSex
			// 
			this.cboSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSex.FormattingEnabled = true;
			this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cboSex.Location = new System.Drawing.Point(65, 395);
			this.cboSex.Name = "cboSex";
			this.cboSex.Size = new System.Drawing.Size(497, 28);
			this.cboSex.TabIndex = 12;
			// 
			// cboClassID
			// 
			this.cboClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboClassID.FormattingEnabled = true;
			this.cboClassID.Location = new System.Drawing.Point(65, 155);
			this.cboClassID.Name = "cboClassID";
			this.cboClassID.Size = new System.Drawing.Size(497, 28);
			this.cboClassID.TabIndex = 11;
			// 
			// txbPhone
			// 
			this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPhone.Location = new System.Drawing.Point(65, 556);
			this.txbPhone.Name = "txbPhone";
			this.txbPhone.Size = new System.Drawing.Size(497, 26);
			this.txbPhone.TabIndex = 10;
			// 
			// txbAddress
			// 
			this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbAddress.Location = new System.Drawing.Point(65, 471);
			this.txbAddress.Name = "txbAddress";
			this.txbAddress.Size = new System.Drawing.Size(497, 26);
			this.txbAddress.TabIndex = 9;
			// 
			// txbStudentName
			// 
			this.txbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbStudentName.Location = new System.Drawing.Point(65, 241);
			this.txbStudentName.Name = "txbStudentName";
			this.txbStudentName.Size = new System.Drawing.Size(497, 26);
			this.txbStudentName.TabIndex = 8;
			// 
			// txbStudentID
			// 
			this.txbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbStudentID.Location = new System.Drawing.Point(65, 83);
			this.txbStudentID.Name = "txbStudentID";
			this.txbStudentID.ReadOnly = true;
			this.txbStudentID.Size = new System.Drawing.Size(497, 26);
			this.txbStudentID.TabIndex = 7;
			this.txbStudentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(61, 533);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 20);
			this.label8.TabIndex = 6;
			this.label8.Text = "Số điện thoại:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(61, 448);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(69, 372);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Giới tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(69, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Họ tên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Lớp:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã sinh viên:";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(95, 644);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(96, 40);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(273, 644);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(96, 40);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(426, 644);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(96, 40);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// ucStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "ucStudent";
			this.Size = new System.Drawing.Size(1525, 749);
			this.Load += new System.EventHandler(this.ucStudent_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvStudent;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpDateOdBirth;
		private System.Windows.Forms.ComboBox cboSex;
		private System.Windows.Forms.ComboBox cboClassID;
		private System.Windows.Forms.TextBox txbPhone;
		private System.Windows.Forms.TextBox txbAddress;
		private System.Windows.Forms.TextBox txbStudentName;
		private System.Windows.Forms.TextBox txbStudentID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
	}
}
