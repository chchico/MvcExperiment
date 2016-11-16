namespace MvcExperiment.GridMvc.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using MvcExperiment.GridMvc.Models;
    using MvcExperiment.GridMvc.Services;

    /// <summary>
    /// Restable
    /// </summary>
    public class RestableController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            var model = CaractorService.GetCaractors().OrderBy(m => m.ID).ToList();

            return this.View(model);
        }
    }
}