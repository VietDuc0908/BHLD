using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BHLD.Data;
using BHLD.Model.Models;
using BHLD.MVC.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace BHLD.MVC.Controllers
{
    public class hu_titleController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_title
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Filter_Row_HuTitles_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetTitles().ToDataSourceResult(request));
        }
        private static IEnumerable<HuTitleViewModel> GetTitles()
        {
            var northwind = new BHLDDbContext();

            return northwind.hu_Titles.Select(order => new HuTitleViewModel
            {
                id = order.id,
                code = order.code,
                title_name = order.title_name
            });
        }
    }
}
