using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Messages;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/hotDog")]
    public class HotDogController : BaseController
    {
        private readonly HotDogManagementService _service = null;

        public HotDogController()
        {
            _service = new HotDogManagementService();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Json(_service.Get(""));
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Json(_service.GetById(id));
        }

        
        [HttpPost]
        [Route("")]
        public IHttpActionResult Save(HotDogDTO hotDogDTO)
        {
          //  if (!hotDogDTO.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });

            ResponseMessage response = new ResponseMessage();

            if (_service.Save(hotDogDTO))
            {
                response.Code = 200;
                response.Body = "HotDog has been saved.";
            }
            else
            {
                response.Code = 200;
                response.Body = "HotDog has not been saved.";
            }

            return Json(response);
        }

        
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (_service.Delete(id))
            {
                response.Code = 200;
                response.Body = "HotDog has been deleted.";
            }
            else
            {
                response.Code = 200;
                response.Body = "HotDog has not been deleted.";
            }

            return Json(response);
        }
    }
}
