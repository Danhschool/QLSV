using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class SubjectDAO
	{
		private static SubjectDAO instance;

		public static SubjectDAO Instance
		{
			get { if(instance == null) instance = new SubjectDAO(); return instance; }
			set => instance = value; }
		private SubjectDAO() { }

		public int CountSubject()
		{
			int c;

			string query = "select * from Subject";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			c = data.Rows.Count;

			return c;
		}
	}
}
