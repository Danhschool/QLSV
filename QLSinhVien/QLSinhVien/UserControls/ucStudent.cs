using QLSinhVien.DAO;
using QLSinhVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien.UserControls
{
	public partial class ucStudent : UserControl
	{
		public ucStudent()
		{
			InitializeComponent();
		}


		#region method

		void LoadAll()
		{
			dgvStudent.DataSource = StudentDAO.Instance.getallStudents();

			List<Class> list = ClassDAO.Instance.GetClasses();
			cboClassID.DataSource = list;
			cboClassID.DisplayMember = "ClassName";

			txbStudentID.DataBindings.Add(new Binding("Text", dgvStudent.DataSource,"StudentID", true, DataSourceUpdateMode.Never));
			cboClassID.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "ClassID", true, DataSourceUpdateMode.Never));
			txbStudentName.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "StudentName", true, DataSourceUpdateMode.Never));
			dtpDateOdBirth.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never));
			cboSex.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Sex", true, DataSourceUpdateMode.Never));
			txbAddress.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Address", true, DataSourceUpdateMode.Never));
			txbPhone.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Phone", true, DataSourceUpdateMode.Never));


		}
		#endregion

		#region events

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		#endregion

		private void ucStudent_Load(object sender, EventArgs e)
		{
			LoadAll();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string ID = "SV00" + StudentDAO.Instance.GetNumSutdent()+1;
			string query = "insert into Student(StudentID,ClassID,StudentName,DateOfBirth,Sex,Address,Phone) values( '" + ID + "', '" + cboClassID.Text + "','"+txbStudentName+"','" + dtpDateOdBirth.Text + "','" + cboSex.Text + "','" + txbAddress.Text + "','" + txbPhone + "')";

			DataProvider.Instance.ExecuteNonQuery(query);

			LoadAll();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "Update Student set StudentName = '" + txbStudentName + "',DateOfBirth = '" + dtpDateOdBirth.Text + "', Sex = '" + cboSex.Text + "',Address='"  +txbAddress.Text + "',Phone='" + txbPhone + "' where StudentID = '" +txbStudentID.Text + "'";
			DataProvider.Instance.ExecuteNonQuery(query);

			LoadAll();

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "delete from Student where StudentID = '" + txbStudentID.Text + "'";
			DataProvider.Instance.ExecuteNonQuery(query);

			LoadAll();
		}
	}
}
