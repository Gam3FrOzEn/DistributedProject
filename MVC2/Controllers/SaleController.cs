using ApplicationService.DTOs;
using MVC.ViewModels;
using MVC2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Index(string Search_Data = "")
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            List<SaleVM> saleVMs = new List<SaleVM>();

            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                foreach (var item in service.GetSales(Search_Data))
                {
                    saleVMs.Add(new SaleVM(item));
                }
            }

            return View(saleVMs);
        }

        public ActionResult Details(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            SaleVM saleVM = new SaleVM();

            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                SaleDTO saleDTO = service.GetSaleById(id);
                //    saleVM.Id = saleDTO.Id;
                saleVM.Quantity = saleDTO.Quantity;
                saleVM.Date = saleDTO.Date;
                saleVM.FinalPrice = saleDTO.FinalPrice;
                saleVM.HotDogId = saleDTO.HotDogId;
                saleVM.ClientId = saleDTO.ClientId;

            }
            return View(saleVM);
        }

        public ActionResult Create()
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            ViewBag.HotDogs = Helpers.LoadUtilities.LoadHotDogData();
            ViewBag.Clients = Helpers.LoadUtilities.LoadClientData();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SaleVM saleVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            try
            {
                using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
                {
                    SaleDTO saleDTO = new SaleDTO
                    {
                        Quantity = saleVM.Quantity,
                        Date = saleVM.Date,
                        FinalPrice = saleVM.FinalPrice,
                        HotDogId = saleVM.HotDogId,
                        ClientId = saleVM.ClientId
                    };
                    service.PostSale(saleDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.HotDogs = Helpers.LoadUtilities.LoadHotDogData();
                ViewBag.Clients = Helpers.LoadUtilities.LoadClientData();
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            ViewBag.HotDogs = Helpers.LoadUtilities.LoadHotDogData();
            ViewBag.Clients = Helpers.LoadUtilities.LoadClientData();
            SaleVM saleVM = new SaleVM();
            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                SaleDTO saleDTO = service.GetSaleById(id);
                //    saleVM.Id = saleDTO.Id;
                saleVM.Quantity = saleDTO.Quantity;
                saleVM.Date = saleDTO.Date;
                saleVM.FinalPrice = saleDTO.FinalPrice;
                saleVM.HotDogId = saleDTO.HotDogId;
                saleVM.ClientId = saleDTO.ClientId;

            }
            return View(saleVM);
        }

        [HttpPost]
        public ActionResult Edit(SaleVM saleVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                SaleDTO saleDTO = new SaleDTO
                {
                    Id = saleVM.Id,
                    Quantity = saleVM.Quantity,
                    Date = saleVM.Date,
                    FinalPrice = saleVM.FinalPrice,
                    HotDogId = saleVM.HotDogId,
                    ClientId = saleVM.ClientId,

                };
                service.PutSale(saleDTO);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                service.DeleteSale(id);
            }
            return RedirectToAction("Index");
        }
    }
}