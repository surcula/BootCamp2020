using Asp_ModelClient.Entities;
using Bibliotheque_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ProjetPersoBootcamp2020.Controllers
{
    public class NovelsController : Controller
    {
        private readonly INovelsService<Novels> _novelsService;

        public NovelsController(INovelsService<Novels> NovelsService)
        {
            _novelsService = NovelsService;
        }
        // GET: NovelsController
        public ActionResult Index()
        {
            return View(_novelsService.GetAll());
        }

        // GET: NovelsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NovelsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NovelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NovelsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NovelsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NovelsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NovelsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
