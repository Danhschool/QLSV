using QLSinhVien.DAO;
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
	public partial class ucScore : UserControl
	{
		public ucScore()
		{
			InitializeComponent();
		}

		private void ucScore_Load(object sender, EventArgs e)
		{
			dgvScore.DataSource = ScoresDAO.Instance.GetAllScores();

			cboSubject.DataBindings.Add(new Binding("Text", dgvScore.DataSource, "ScoresID" , true, DataSourceUpdateMode.Never));
			cboStudent.DataBindings.Add(new Binding("Text", dgvScore.DataSource, "StudentID", true, DataSourceUpdateMode.Never));
			dtpDate.DataBindings.Add(new Binding("Text", dgvScore.DataSource,"Date", true, DataSourceUpdateMode.Never));
			txbScore.DataBindings.Add(new Binding("Text", dgvScore.DataSource, "Score", true, DataSourceUpdateMode.Never));
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string id = "DHP00" + ScoresDAO.Instance.CountScore() +1;
			string query = "insert into Score(ScoreID,SubjectID,StudentID,Score,date) values ('"+ id+"','"+cboSubject.Text + "','" + cboStudent.Text+"','"+txbScore.Text + "','"+dtpDate.Text+"')";

			DataProvider.Instance.ExecuteNonQuery(query);
			dgvScore.DataSource = ScoresDAO.Instance.GetAllScores();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "update Scores set Score = '"+txbScore.Text+"' where ScoresID ='"+ txbScore.Text+"'";

			DataProvider.Instance.ExecuteNonQuery(query);
			dgvScore.DataSource = ScoresDAO.Instance.GetAllScores();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "delete Scores where ScoresID ='" + txbScore.Text + "'";

			DataProvider.Instance.ExecuteNonQuery(query);
			dgvScore.DataSource = ScoresDAO.Instance.GetAllScores();
		}
	}
}
