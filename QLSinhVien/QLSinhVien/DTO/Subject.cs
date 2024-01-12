using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Subject
	{
		public Subject(string subjectID,  string teacherID, string subjectName)
		{
			this.SubjectID = subjectID;
			this.TeacherID = teacherID;
			this.SubjectName = subjectName;
		}

		public Subject(DataRow r)
		{
			this.SubjectID = r["SubjectID"].ToString();
			this.TeacherID = r["TeacherID"].ToString();
			this.SubjectName = r["SucjectID"].ToString() ;
		}

		private string subjectID;
		private string subjectName;
		private string teacherID;

		public string SubjectID { get => subjectID; set => subjectID = value; }
		public string SubjectName { get => subjectName; set => subjectName = value; }
		public string TeacherID { get => teacherID; set => teacherID = value; }
	}
}
