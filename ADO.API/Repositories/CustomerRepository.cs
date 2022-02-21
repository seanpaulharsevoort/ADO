using System;
using ADO.API.Models;

namespace ADO.API.Repositories
{
	public class CustomerRepository : BaseRepository
	{
		public CustomerRepository(AdoDbContext dbContext) : base(dbContext)
		{

		}
	}
}
