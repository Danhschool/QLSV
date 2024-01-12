using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Class
	{
		public Class(string classID, string className, string majorID, string teacherID, string cource)
		{
			this.ClassID = classID;
			this.ClassName = className;
			this.MajorID = majorID;
			this.TeacherID = teacherID;
			this.Cource = cource;
		}

		public Class(DataRow r)
		{
			this.ClassID = r["ClassID"].ToString();
			this.ClassName = r["ClassName"].ToString() ;
			this.MajorID = r["MajorID"].ToString();
			this.TeacherID = r["TeacherID"].ToString();
			this.Cource = r["Course"].ToString();
		}

		private string classID;
		private string className;
		private string majorID;
		private string teacherID;
		private string cource;

		public string ClassID { get => classID; set => classID = value; }
		public string ClassName { get => className; set => className = value; }
		public string MajorID { get => majorID; set => majorID = value; }
		public string TeacherID { get => teacherID; set => teacherID = value; }
		public string Cource { get => cource; set => cource = value; }
	}
}
