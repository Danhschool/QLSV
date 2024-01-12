using QLSinhVien.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
	public partial class fTableManager : Form
	{
		public fTableManager()
		{
			InitializeComponent();

			ucHomePage uc = new ucHomePage();
			AddUserControls(uc);
		}

		private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();

		}

		private void AddUserControls(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			pnMain.Controls.Clear();
			pnMain.Controls.Add(userControl);
			userControl.BringToFront();
		}

		private void btnHomePage_Click(object sender, EventArgs e)
		{
			ucHomePage uc = new ucHomePage();
			AddUserControls(uc);
			
		}

		private void btnStudent_Click(object sender, EventArgs e)
		{
			ucStudent uc = new ucStudent();
			AddUserControls(uc);	
		}

		private void btnSubject_Click(object sender, EventArgs e)
		{
			ucSubject uc = new ucSubject();
			AddUserControls(uc);
		}

		private void btnScore_Click(object sender, EventArgs e)
		{
			ucScore uc = new ucScore();
			AddUserControls(uc);
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			ucSetting uc = new ucSetting();	
			AddUserControls(uc);
		}
	}
}
