using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
	public interface IGenericService<TEntity, TModel> where TEntity : class, new() where TModel : class, new()
	{
		DbSet<TEntity> Get();
		Task<TModel> GetByIdAsync(int id);
		Task<Response<TModel>> UpdateAsync(TEntity entity);
		Task<Response<TEntity>> AddAsync(TEntity entity);
		Task<int> DeleteByIdAsync(int id);
		Task<List<TModel>> GetAll();


	}
}
