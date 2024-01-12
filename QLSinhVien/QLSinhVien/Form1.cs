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
	public partial class frmSignin : Form
	{
		public frmSignin()
		{
			InitializeComponent();

			LoadIcon();
		}

		void LoadIcon()
		{
			ptSignIn.Image = Image.FromFile(Application.StartupPath + "\\image\\signin.png");
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			fTableManager f = new fTableManager();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmSignin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
	}
}
