using BHLD.Model.Models;
using BHLD.MVC.Infrastructure.Core;
using BHLD.Services;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BHLD.MVC.API
{
    public class HuTitleController : APIControllerBase
    {
        hu_titleServices _titleServices;
        public HuTitleController(IErrorService errorService, hu_titleServices TitleServices):
            base(errorService)
        {
            this._titleServices = TitleServices;
        }





        //get
        public HttpResponseMessage GET(HttpRequestMessage request, hu_title hu_Title)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listTitle = _titleServices.GetAll();
                    //  response = request.CreateResponse(HttpStatusCode.Created, title );
                }
                return response;
            }
            );
        }
        //
        public HttpResponseMessage Post(HttpRequestMessage request, hu_title hu_Title)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else {
                         _titleServices.Add(hu_Title);
                         _titleServices.SaveChanges();
                      //  response = request.CreateResponse(HttpStatusCode.Created, title );
                }
                return response;
            }
            );
        }
    }
}
