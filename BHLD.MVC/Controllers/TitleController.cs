using BHLD.Data;
using BHLD.MVC.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHLD.MVC.Controllers
{
    public class TitleController : Controller
    {
        // GET: Hu_Title
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