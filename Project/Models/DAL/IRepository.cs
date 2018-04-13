using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Project.Models.DAL
{
    public interface IRepository<T>
    {
        Task<IList<T>> GetEntities();
        Task<T> getEntity(int id);
        Task<T> PutEntity(T Entity);
        Task<T> PostEntity(T Entity);
        Task<T> Delete(int id);
    }
}