using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.DTO
{
	public class Major
	{
		public Major(string majorID, string majorName)
		{
			this.MajorID = majorID;
			this.MajorName = majorName;
		}

		public Major(DataRow row)
		{
			this.MajorID = row["MajorID"].ToString();
			this.MajorName = row["MajorName"].ToString() ;
		}
		private string majorID;
		private string majorName;

		public string MajorID { get => majorID; set => majorID = value; }
		public string MajorName { get => majorName; set => majorName = value; }
	}
}
