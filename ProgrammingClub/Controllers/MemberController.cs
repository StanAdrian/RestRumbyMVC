﻿using ProgrammingClub.Models;
using ProgrammingClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgrammingClub.Controllers
{
    public class MemberController : Controller
    {
        MemberRepository memberRepository = new MemberRepository();
        // GET: Member
        public ActionResult Index()
        {
            List<MemberModel> members = memberRepository.GetAllMembers();
            return View("Index", members);
        }

        // GET: Member/Details/5
        public ActionResult Details(Guid id)
        {
            MemberModel memberModel = memberRepository.GetMemberById(id);
            return View("DetailsMember", memberModel);
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View("CreateMember");
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                MemberModel memberModel = new MemberModel();
                UpdateModel(memberModel);
                memberRepository.InsertMember(memberModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateMember");
            }
        }

        // GET: Member/Edit/5
        public ActionResult Edit(Guid id)
        {
            MemberModel memberModel = memberRepository.GetMemberById(id);
            return View("EditMember", memberModel);
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                MemberModel memberModel = new MemberModel();
                UpdateModel(memberModel);
                memberRepository.UpdateMember(memberModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditMember");
            }
        }

        // GET: Member/Delete/5
        public ActionResult Delete(Guid id)
        {
            MemberModel memberModel = memberRepository.GetMemberById(id);
            return View("DeleteMember", memberModel);
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                memberRepository.DeleteMember(id);                
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteMember");
            }
        }
    }
}
