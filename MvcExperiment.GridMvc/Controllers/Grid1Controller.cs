namespace MvcExperiment.GridMvc.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using MvcExperiment.GridMvc.Models;
    using MvcExperiment.GridMvc.Services;

    /// <summary>
    /// Grid1
    /// </summary>
    public class Grid1Controller : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            var model = CaractorService.GetCaractors().OrderBy(m => m.ID).ToList();

            this.TempData["Grid1List"] = model;

            return this.View(model);
        }

        /// <summary>
        /// 一覧取得
        /// </summary>
        /// <returns>パーシャルビュー</returns>
        public ActionResult GetList(int scroll)
        {
            var model = this.TempData["Grid1List"] as List<Caractor> ?? new List<Caractor>();
            this.TempData["Grid1List"] = model;

            ViewBag.RenderRowsOnly = true;
            ViewBag.Scroll = scroll;

            return this.PartialView("_List", model);
        }
    }
}