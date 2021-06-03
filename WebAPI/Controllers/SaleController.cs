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
    [RoutePrefix("api/sale")]
    public class SaleController : BaseController
    {
        private readonly SaleManagementService _service = null;

        public SaleController()
        {
            _service = new SaleManagementService();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
           // var str = _service.Get();
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
        public IHttpActionResult Save(SaleDTO saleDTO)
        {
            //  if (!saleDTO.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });

            ResponseMessage response = new ResponseMessage();

            if (_service.Save(saleDTO))
            {
                response.Code = 200;
                response.Body = "Sale has been saved.";
            }
            else
            {
                response.Code = 200;
                response.Body = "Sale has not been saved.";
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
                response.Body = "Sale has been deleted.";
            }
            else
            {
                response.Code = 200;
                response.Body = "Sale has not been deleted.";
            }

            return Json(response);
        }
    }
}