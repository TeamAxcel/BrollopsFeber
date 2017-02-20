using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using brollopsfeber.Domain.Abstract;

namespace brollopsfeber.Web.GUI.Controllers
{
    public class ExhibitorController : Controller
    {
        private IExhibitorRepository _repo;

        public ExhibitorController(IExhibitorRepository repo)
        {
            _repo = repo;
        }

        public ViewResult ViewExhibitors()
        {
            return View(_repo.Exhibitors);
        }
    }
}