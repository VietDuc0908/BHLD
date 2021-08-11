using BHLD.Model.Models;
using BHLD.MVC.Infrastructure.Core;
using BHLD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BHLD.MVC.API
{
    public class HuTitleController : APIControllerBase
    {
        hu_titleServices _TitleServices;
        public HuTitleController(IErrorService errorService, hu_titleServices TitleServices):
            base(errorService)
        {
            this._TitleServices = TitleServices;
        }
       public HttpResponseMessage Create(HttpRequestMessage request, hu_title hu_Title)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else {
                         _TitleServices.Add(hu_Title);
                         _TitleServices.SaveChanges();
                      //  response = request.CreateResponse(HttpStatusCode.Created, title );
                }
                return response;
            }
            );
        }
    }
}
