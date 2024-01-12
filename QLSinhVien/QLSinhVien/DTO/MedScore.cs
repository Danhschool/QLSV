using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class MedScore
	{
		public MedScore(string studentID, float aVGScore, float gPA)
		{
			this.StudentID = studentID;
			this.AVGScore = AVGScore;
			this.GPA = gPA;
		}

		public MedScore(DataRow r)
		{
			this.StudentID = r["StudentID"].ToString();
			this.AVGScore = (float)r["AVGScore"];
			this.GPA = (float)r["GPA"];
		}
		private string studentID;
		private float aVGScore;
		private float gPA;

		public string StudentID { get => studentID; set => studentID = value; }
		public float AVGScore { get => aVGScore; set => aVGScore = value; }
		public float GPA { get => gPA; set => gPA = value; }
	}
}
