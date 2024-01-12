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
	public partial class ucHomePage : UserControl
	{
		public ucHomePage()
		{
			InitializeComponent();

			
		}


		#region method
		void LoadIcon()
		{
			ptClass.Image = Image.FromFile(Application.StartupPath + "\\image\\class.jpg");
			ptStudent.Image = Image.FromFile(Application.StartupPath + "\\image\\student.png");
			ptSubject.Image = Image.FromFile(Application.StartupPath + "\\image\\subject.png");
			ptMajor.Image = Image.FromFile(Application.StartupPath + "\\image\\major.jpg");
		}

		void LoadClass()
		{
			List<Class> list = ClassDAO.Instance.GetClasses();
			cboClass.DataSource = list;
			cboClass.DisplayMember = "ClassName";
		}

		void loadall()
		{
			lblCountStudent.Text = StudentDAO.Instance.GetNumSutdent().ToString();
			lblCountClass.Text = ClassDAO.Instance.CountClass().ToString();	
			lblCountSubject.Text = SubjectDAO.Instance.CountSubject().ToString();
			lblCountMajor.Text = MajorDAO.Instance.CountMajor().ToString();
		}

		#endregion

		#region events

		private void ucHomePage_Load(object sender, EventArgs e)
		{
			LoadIcon();
			LoadClass();
			loadall();
		}
		#endregion

	}
}
