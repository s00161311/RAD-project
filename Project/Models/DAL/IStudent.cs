using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Project.Models.DAL
{
    public interface IStudent : IRepository<Student>
    {
        Task<IList<Delivery>> StudentDeliveries();
    }
}