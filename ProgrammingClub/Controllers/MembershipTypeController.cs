using ProgrammingClub.Models;
using ProgrammingClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgrammingClub.Controllers
{
    public class MembershipTypeController : Controller
    {
        private MembershipTypeRepository membershipTypeRepository = new MembershipTypeRepository();
        // GET: MembershipType
        public ActionResult Index()
        {
            List<MembershipTypeModel> membershipTypeModels = membershipTypeRepository.GetAllMembershipTypeModel();
            return View("Index", membershipTypeModels);
        }

        // GET: MembershipType/Details/5
        public ActionResult Details(Guid id)
        {
            MembershipTypeModel membershipTypeModel = membershipTypeRepository.
                GetMembershipTypeModelById(id);
            return View("DetailsMembershipType", membershipTypeModel);
        }

        // GET: MembershipType/Create
        public ActionResult Create()
        {
            return View("CreateMembershipType");
        }

        // POST: MembershipType/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                MembershipTypeModel membershipTypeModel = new MembershipTypeModel();
                UpdateModel(membershipTypeModel); // preluare date model din form
                membershipTypeRepository.InsertMembershipType(membershipTypeModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateMembershipType");
            }
        }

        // GET: MembershipType/Edit/5
        public ActionResult Edit(Guid id)
        {
            MembershipTypeModel membershipTypeModel = membershipTypeRepository.GetMembershipTypeModelById(id);          
            return View("EditMembershipType",membershipTypeModel);
        }

        // POST: MembershipType/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                MembershipTypeModel membershipTypeModel = new MembershipTypeModel();
                UpdateModel(membershipTypeModel);
                membershipTypeRepository.UpdateMembershipTypeModel(membershipTypeModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditMembershipType");
            }
        }

        // GET: MembershipType/Delete/5
        public ActionResult Delete(Guid id)
        {
            MembershipTypeModel membershipTypeModel = membershipTypeRepository.
                GetMembershipTypeModelById(id);
            return View("DeleteMembershipType", membershipTypeModel);
        }

        // POST: MembershipType/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                membershipTypeRepository.DeleteMembershipTypeModel(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteMembershipType");
            }
        }
    }
}
