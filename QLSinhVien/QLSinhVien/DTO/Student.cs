using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Student
	{
		public Student(string strudentID, string classID, string studentName, DateTime dateOfBirth, int sex, string address, string phone)
		{
			this.StudentID = strudentID;
			this.ClassID = classID;
			this.StudentName = studentName;
			this.DateOfBirth = dateOfBirth;
			this.Sex = sex;
			this.Address = address;
			this.Phone = phone;
		}

		public Student(DataRow r)
		{
			this.StudentID = r["StudentID"].ToString();
			this.ClassID= r["ClassID"].ToString();
			this.StudentName = r["StudentName"].ToString() ;
			this.DateOfBirth = (DateTime)r["DateOfBirth"];
			this.Sex = (int)r["Sex"];
			this.Address = r["Address"].ToString();
			this.Phone = r["Phone"].ToString();
		}

		private string studentID;
		private string classID;
		private string studentName;
		private DateTime dateOfBirth;
		private int sex;
		private string address;
		private string phone;

		public string StudentID { get => studentID; set => studentID = value; }
		public string ClassID { get => classID; set => classID = value; }
		public string StudentName { get => studentName; set => studentName = value; }
		public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
		public int Sex { get => sex; set => sex = value; }
		public string Address { get => address; set => address = value; }
		public string Phone { get => phone; set => phone = value; }
	}
}
