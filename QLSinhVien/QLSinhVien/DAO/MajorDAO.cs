using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class MajorDAO
	{
		private static MajorDAO instance;

		public static MajorDAO Instance
		{
			get { if(instance == null) instance = new MajorDAO(); return instance; }
			set => instance = value; }

		private MajorDAO() { }

		public int CountMajor()
		{
			int c;
			string query = "select * from Major";
			DataTable dt = DataProvider.Instance.ExecuteQuery(query);

			c = dt.Rows.Count;

			return c;
		}
	}
}
