using ProgrammingClub.Models;
using ProgrammingClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgrammingClub.Controllers
{
    public class AnnouncementsController : Controller
    {
        private AnnouncementRepository announcementRepository = new AnnouncementRepository();
        // GET: Announcements
        public ActionResult Index()
        {
            List<AnnouncementModel> announcements = announcementRepository.
                GetAllAnnouncements();
            return View("Index", announcements);
        }

        // GET: Announcements/Details/5
        public ActionResult Details(Guid id)
        {
            AnnouncementModel announcementModel = announcementRepository.
                GetAnnouncementById(id);
            return View("DetailsAnnouncement", announcementModel);
        }

        // GET: Announcements/Create
        public ActionResult Create()
        {
            return View("CreateAnnouncement");
        }

        [Authorize(Roles ="Admin, User")]
        // POST: Announcements/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                AnnouncementModel announcementModel = new AnnouncementModel();
                UpdateModel(announcementModel); //preiau datele din form collection si le punem in announcementModel
                announcementRepository.InsertAnnouncement(announcementModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateAnnouncement");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Announcements/Edit/5
        public ActionResult Edit(Guid id)
        {
            AnnouncementModel announcementModel = announcementRepository.GetAnnouncementById(id);
            return View("EditAnnouncement", announcementModel);
        }

        // POST: Announcements/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                AnnouncementModel announcementModel = new AnnouncementModel();
                UpdateModel(announcementModel);
                announcementRepository.UpdateAnnouncements(announcementModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditAnnouncement");
            }
        }
        [Authorize(Roles ="Admin")]
        // GET: Announcements/Delete/5
        public ActionResult Delete(Guid id)
        {
            AnnouncementModel announcementModel = announcementRepository.
                GetAnnouncementById(id);
            
            return View("Delete", announcementModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: Announcements/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                announcementRepository.DeleteAnnouncement(id);                
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Delete");
            }
        }
    }
}
