using QLSinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class StudentDAO
	{
		private static StudentDAO instance;

		public static StudentDAO Instance {
			get { if(instance == null) instance = new StudentDAO(); return instance; }
			set => instance = value; }

		private StudentDAO() { }

		public List<Student> GetStudents()
		{
			List<Student> s = new List<Student>();

			string query = "select * from Student";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in data.Rows)
			{
				Student st = new Student(row);
				s.Add(st);
			}
			return s;
		}

		public List<Student> getallStudents()
		{
			List<Student> s = new List<Student>();
			string query = "select StudentID , s.ClassID, StudentName , DateOfBirth, Sex , Address , Phone  from Student s join Class c on s.ClassID=c.ClassID";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				Student student = new Student(row);
				s.Add(student);
			}

			return s;
		}

		
		public int GetNumSutdent()
		{
			int s;
			string query = "select * from Student";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			s = data.Rows.Count;

			return s;
		}


	}
}
