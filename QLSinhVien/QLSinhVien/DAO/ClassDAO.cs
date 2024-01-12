using QLSinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class ClassDAO
	{
		private static ClassDAO instance;

		public static ClassDAO Instance {
			get { if(instance == null)  instance = new ClassDAO(); return instance; }
			set => instance = value; }

		private ClassDAO() { }

		public List<Class> GetClasses()
		{
			List<Class> classes = new List<Class>();

			string query = "select * from Class";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow r in data.Rows)
            {
				Class c = new Class(r);
				classes.Add(c);
            }
			return classes;
        }

		public int CountClass()
		{
			int c;
			string query = "select * from Class";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			c = data.Rows.Count;

			return c;
		}
	}
}
