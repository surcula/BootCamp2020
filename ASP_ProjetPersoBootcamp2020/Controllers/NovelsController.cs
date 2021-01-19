using Asp_ModelClient.Entities;
using ASP_ProjetPersoBootcamp2020.Models;
using Bibliotheque_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ProjetPersoBootcamp2020.Controllers
{
    public class NovelsController : Controller
    {
        private readonly INovelsService<Novels> _novelsService;
        private readonly ISeriesService<Series> _seriessService;
        private readonly ITypesService<Types> _typesService;

        public NovelsController(INovelsService<Novels> NovelsService, ISeriesService<Series> SeriessService, ITypesService<Types> TypesService)
        {
            _novelsService = NovelsService;
            _seriessService = SeriessService;
            _typesService = TypesService;
        }
        // GET: NovelsController
        public ActionResult Index()
        {
            try
            {
                IEnumerable<Novels> Novels = _novelsService.GetAll();
                return View(Novels);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET: NovelsController/Details/5
        public ActionResult Details(int id)
        {
            try
            {               
                return View(_novelsService.GetOne(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET: NovelsController/Create
        [HttpGet]
        public ActionResult Create()
        {
            NovelsForm novelform = new NovelsForm();
            novelform.SerieId = 0;            
            novelform.Series = GetSerie();
            novelform.TypeId = 0;
            novelform.Types = GetType();
            return View(novelform);
        }

        // POST: NovelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NovelsForm novelsForm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _novelsService.Add(new Novels()
                    {
                        
                        Title = novelsForm.Title,
                        SerieId = novelsForm.SerieId,
                        Authors = novelsForm.Authors,
                        SerialNumber = novelsForm.SerialNumber,
                        Price = novelsForm.Price,
                        Informations = novelsForm.Informations,
                        Langue = novelsForm.Langue,
                        Dimension = novelsForm.Dimension,
                        Published = novelsForm.Published,
                        TypeId = novelsForm.TypeId,
                    });
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    return View();
                }
            }
            return BadRequest();            
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
        private List<SelectListItem> GetSerie()
        { 
            List<SelectListItem> serie = _seriessService.GetAll().Select(s => new SelectListItem(s.Nom, s.Id.ToString())).ToList();
            serie.Insert(0, new SelectListItem("--- select Serie ---", null));
            return serie;
        }

        private List<SelectListItem> GetType()
        {
            List<SelectListItem> type = _typesService.GetAll().Select(t => new SelectListItem(t.Type, t.Id.ToString())).ToList();
            type.Insert(0, new SelectListItem("--- select Type ---", null));
            return type;
        }
    }
}

