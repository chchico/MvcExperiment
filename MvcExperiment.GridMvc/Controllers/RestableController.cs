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
        /// Demo1
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Demo1()
        {
            var model = CaractorService.GetCaractors().OrderBy(m => m.ID).ToList();

            return this.View(model);
        }

        /// <summary>
        /// Demo2
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Demo2()
        {
            var model = CaractorService.GetCaractors().OrderBy(m => m.ID).ToList();

            return this.View(model);
        }
    }
}