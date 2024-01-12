using QLSinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class ScoresDAO
	{
		private static ScoresDAO instance;

		public static ScoresDAO Instance {
			get { if(instance == null) instance = new ScoresDAO(); return instance; }
			set => instance = value; }

		private ScoresDAO() { }

		public List<Scores> GetAllScores()
		{

			List<Scores> scores = new List<Scores>();

			string query = "select * from Scores";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				Scores s = new Scores(row);
				scores.Add(s);
			}

			return scores;	

	
		}

		public int CountScore()
		{
			int s;

			string query = "select* from Scores";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			s= dt.Rows.Count;

			return s;
		}
	}
}
