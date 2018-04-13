using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Project.Models.DAL
{
    public class MainRepository : ILecturer, IStudent, IDelivery, IDisposable
    {
        private ProjectDbContext context;

        public MainRepository(ProjectDbContext context)
        {
            this.context = context;
        }


        async Task<IList<Student>> IStudent.StudentDeliveries()
        {
         return await context.Deliveries.Include("associatedAttendance").ToListAsync();
        }





        public void Dispose()
        {
            this.Dispose();
        }

      async  Task<Lecturer> IRepository<Lecturer>.Delete(int id)
        {

            Lecturer lecturer = await context.Lecrurers.FindAsync(id);
            if (lecturer == null)
            {
                return null;
            }
            context.Lecrurers.Remove(lecturer);
            await context.SaveChangesAsync();
            return lecturer;
        }
        async Task<Delivery> IRepository<Delivery>.Delete(int id)
        {

            Delivery delivery = await context.Deliveries.FindAsync(id);
            if (delivery == null)
            {
                return null;
            }
            context.Deliveries.Remove(delivery);
            await context.SaveChangesAsync();
            return delivery;
        }
       async Task<Student> IRepository<Student>.Delete(int id)
        {

            Student student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return null;
            }
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return student;
        }


        async Task<IList<Lecturer>> IRepository<Lecturer>.GetEntities()
        {
            return await context.Lecrurers.ToListAsync();
        }
        async Task<IList<Delivery>> IRepository<Delivery>.GetEntities()
        {
            return await context.Deliveries.ToListAsync();        }
        async Task<IList<Student>> IRepository<Student>.GetEntities()
        {
            return await context.Students.ToListAsync();
        }


        async Task<Lecturer> IRepository<Lecturer>.getEntity(int id)
        {
            Lecturer lecturer = await context.Lecrurers.FindAsync(id);
            if(lecturer == null)
            {
                return null;
            }
            return lecturer;
        }
        async Task<Delivery> IRepository<Delivery>.getEntity(int id)
        {
            Delivery delivery = await context.Deliveries.FindAsync(id);
            if (delivery == null)
            {
                return null;
            }
            return delivery;
        }
        async Task<Student> IRepository<Student>.getEntity(int id)
        {
            Student student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return null;
            }
            return student;
        }



        async Task<Lecturer> IRepository<Lecturer>.PostEntity(Lecturer Entity)
        {
            context.Lecrurers.Add(Entity);
            await context.SaveChangesAsync();
            return Entity;
        }
        async Task<Delivery> IRepository<Delivery>.PostEntity(Delivery Entity)
        {
            context.Deliveries.Add(Entity);
            await context.SaveChangesAsync();
            return Entity;
        }
        async Task<Student> IRepository<Student>.PostEntity(Student Entity)
        {
            context.Students.Add(Entity);
            await context.SaveChangesAsync();
            return Entity;
        }



        async Task<Lecturer> IRepository<Lecturer>.PutEntity(Lecturer Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return Entity;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LecturerExists(Entity.LecturerID))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }
        async Task<Delivery> IRepository<Delivery>.PutEntity(Delivery Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return Entity;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(Entity.DeliveryID))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }
        async Task<Student> IRepository<Student>.PutEntity(Student Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return Entity;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Entity.StudentID))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

            private bool LecturerExists(int id)
        {
            return context.Lecrurers.Count(e => e.LecturerID == id) > 0;
        }

        private bool StudentExists(int id)
        {
            return context.Students.Count(e => e.StudentID == id) > 0;
        }

        private bool DeliveryExists(int id)
        {
            return context.Deliveries.Count(e => e.DeliveryID == id) > 0;
        }
    }
}