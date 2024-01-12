using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Teacher
	{
		public Teacher(string teacherID, string teacherName,string passwords, DateTime dateOfBirth, int sex, string address, string phone)
		{
			this.TeacherId = teacherID;
			this.TeacherName = teacherName;
			this.Passwords = passwords;
			this.DateOfBirth = dateOfBirth;
			this.Sex = sex;
			this.Address = address;
			this.Phone = phone;
		}

		public Teacher(DataRow r)
		{
			this.TeacherId = r["TeacherID"].ToString();
			this.TeacherName = r["TeacherName"].ToString() ;
			this.Passwords = r["Password"].ToString() ;
			this.DateOfBirth = (DateTime)r["DateOfBirth"];
			this.Sex = (int)r["Sex"];
			this.Address = r["Address"].ToString();
			this.Phone = r["Phone"].ToString();
		}

		private string teacherId;
		private string teacherName;
		private string passwords;
		private DateTime dateOfBirth;
		private int sex;
		private string address;
		private string phone;

		public string TeacherId { get => teacherId; set => teacherId = value; }
		public string TeacherName { get => teacherName; set => teacherName = value; }
		public string Passwords { get => passwords; set => passwords = value; }
		public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
		public int Sex { get => sex; set => sex = value; }
		public string Address { get => address; set => address = value; }
		public string Phone { get => phone; set => phone = value; }
	}
}
