using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdGradAssist.Models.Entities;

namespace EdGradAssist
{
	public class DbGradadRepository
	{
		private GRADAD_DBContext _db;

		public DbGradadRepository(GRADAD_DBContext db)
		{
			_db = db;
		}



	}
}
