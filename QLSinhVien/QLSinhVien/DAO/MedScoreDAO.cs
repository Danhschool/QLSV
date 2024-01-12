using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DAO
{
	public class MedScoreDAO
	{
		private static MedScoreDAO instance;

		public static MedScoreDAO Instance { get
			{ if (instance == null) instance = new MedScoreDAO(); return instance; } set => instance = value; }

		private MedScoreDAO() { }
	}
}
