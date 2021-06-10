using ComplementoParcial.Models;
using ComplementoParcial.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplementoParcial.Controllers
{
    public class DiscosController : Controller
    {
        private readonly IVentas db = new RVentas();
        // GET: Discos
        public ActionResult Index()
        {
            var items = db.GetMostSold();
            DiscosLimitResponse resp = new DiscosLimitResponse
            {
                discos = items
            };
            return View(resp);
        }
        [HttpPost]
        public ActionResult Index(DiscosLimitResponse item)
        {
            var items = db.GetMostSoldFiltered(item.desde, item.hasta);
            DiscosLimitResponse resp = new DiscosLimitResponse
            {
                desde=item.desde,
                hasta=item.hasta,
                discos = items
            };
            return View(resp);
        }
    }
}