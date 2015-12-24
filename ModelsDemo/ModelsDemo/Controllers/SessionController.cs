using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsDemo.Models;

namespace ModelsDemo.Controllers
{
    public class SessionController : Controller
    {
        ConfContext context = new ConfContext();
        // GET: Session
        public ActionResult Index()
        {
            List<Session> sessions = context.Sessions.ToList();
            return View("anyViewName",sessions);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid)
            {
                return View(session);
            }
            try
            {
                context.Sessions.Add(session);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(session);
            }

            TempData["message"] = "Created" + session.Title;
            return RedirectToAction("Index");
        }
    }
}