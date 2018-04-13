using Project.Models;
using Project.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    [Authorize(Roles = "Lecturer")]
    [RoutePrefix("api/Deliveries")]
    public class DeliveriesController : ApiController
    {
        private MainRepository context;

        public DeliveriesController()
        {
            context = new MainRepository(new Models.ProjectDbContext());
        }

        public DeliveriesController(MainRepository ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [Route("Deliveries")]
        public async TaskEventHandler<IList<Delivery>> GetDeliveries()
        {
            return await (context as IDelivery).GetEntities();
        }

        [HttpGet]
        [Route("Lecturers")]
        public async TaskEventHandler<IList<Lecturer>> GetLecturers()
        {
            return await (context as IDelivery).GetEntities();
        }

        [HttpGet]
        [Route("Students")]
        public async TaskEventHandler<IList<Student>> GetStudents()
        {
            return await (context as IDelivery).GetEntities();
        }
        // GET: Deliveries/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deliveries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deliveries/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deliveries/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deliveries/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deliveries/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deliveries/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
