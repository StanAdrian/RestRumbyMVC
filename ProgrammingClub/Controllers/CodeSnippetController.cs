﻿using ProgrammingClub.Models;
using ProgrammingClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgrammingClub.Controllers
{    
    public class CodeSnippetController : Controller
    {
        CodeSnippetRepository codeSnippetRepository = new CodeSnippetRepository();
        [Authorize(Roles = "Admin, User, Visitor")]
        // GET: CodeSnippet
        public ActionResult Index()
        {
            List<CodeSnippetModel> codeSnippets = codeSnippetRepository.GetAllCodeSnippets(); 
            return View("Index", codeSnippets);
        }

        // GET: CodeSnippet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        
        // GET: CodeSnippet/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: CodeSnippet/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                CodeSnippetModel codeSnippetModel = new CodeSnippetModel();
                UpdateModel(codeSnippetModel);
                codeSnippetRepository.InsertCodeSnippet(codeSnippetModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Create");
            }
        }

        // GET: CodeSnippet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CodeSnippet/Edit/5
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

        // GET: CodeSnippet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CodeSnippet/Delete/5
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
