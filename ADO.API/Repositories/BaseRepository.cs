using System;
using ADO.API.Models;
namespace ADO.API.Repositories
{
	public class BaseRepository
	{
		protected AdoDbContext _dbContext;

		public BaseRepository(AdoDbContext dbContext)
		{
			this._dbContext = dbContext;
		}
	}
}
