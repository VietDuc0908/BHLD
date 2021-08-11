using BHLD.Model.Models;
using BHLD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BHLD.MVC.Controllers
{
    public class HomeController : ApiController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        private hu_titleServices hu_title_service = new hu_titleServices();
        // GET: Hu_title
        [System.Web.Http.HttpGet]
        public IEnumerable<hu_title> GetAllList()
        {
            return hu_title_service.GetAll();
        }
        [System.Web.Http.HttpPost]
        public bool Post(hu_title title)
        {
            if (title != null)
            {
                hu_title_service.Add(title);
                return true;
            }
            return false;
        }
        [System.Web.Http.HttpDelete]
        public bool Delete(int id)
        {
            return false;

        }
    }
}