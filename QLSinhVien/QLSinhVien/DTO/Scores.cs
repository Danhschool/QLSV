using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Scores
	{
		public Scores(string scoresID, string subjectID, string studentID, float score, DateTime date)
		{
			this.ScoresID = scoresID;
			this.SubjectID = subjectID;
			this.StudentID = studentID;
			this.Score = score;
			this.Date = date;
		}

		public Scores(DataRow r)
		{
			this.ScoresID = r["ScoresID"].ToString();
			this.SubjectID = r["SubjectID"].ToString() ;
			this.StudentID = r["StudentID"].ToString();
			this.Score = (double)r["Score"];
			this.Date = (DateTime)r["Date"];
		}

		private string scoresID;
		private string subjectID;
		private string studentID;
		private double score;
		private DateTime date;

		public string ScoresID { get => scoresID; set => scoresID = value; }
		public string SubjectID { get => subjectID; set => subjectID = value; }
		public string StudentID { get => studentID; set => studentID = value; }
		public double Score { get => score; set => score = value; }
		public DateTime Date { get => date; set => date = value; }
	}
}
