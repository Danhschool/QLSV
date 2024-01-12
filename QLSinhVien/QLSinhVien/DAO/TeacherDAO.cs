using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class TeacherDAO
	{
		private static TeacherDAO instance;

		public static TeacherDAO Instance {
			get { if(instance == null) instance = new TeacherDAO(); return instance; }
			set => instance = value; }

		private TeacherDAO() { }	
	}
}
