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
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index(string Search_Data = "")
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            List<ClientVM> clientVMs = new List<ClientVM>();

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                foreach (var item in service.GetClients(Search_Data))
                {
                    clientVMs.Add(new ClientVM(item));
                }
            }

            return View(clientVMs);
        }

        public ActionResult Details(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            ClientVM clientVM = new ClientVM();

            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                var clientDTO = service.GetClientByID(id);
                clientVM = new ClientVM(clientDTO);
            }
            return View(clientVM);
        }

        public ActionResult Create()
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientVM clientVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            try
            {
                using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
                {
                    ClientDTO clientDTO = new ClientDTO
                    {
                        Name = clientVM.Name,
                        Age = clientVM.Age,
                        Email = clientVM.Email,
                        Number = clientVM.Number,
                        City = clientVM.City,
                        Neighborhood = clientVM.Neighborhood,
                        Street = clientVM.Street,
                    };
                    service.PostClient(clientDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            ClientVM clientVM = new ClientVM();
            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                ClientDTO clientDTO = service.GetClientByID(id);
                clientVM.Id = clientDTO.Id;
                clientVM.Name = clientDTO.Name;
                clientVM.Age = clientDTO.Age;
                clientVM.Email = clientDTO.Email;
                clientVM.Number = clientDTO.Number;
                clientVM.City = clientDTO.City;
                clientVM.Neighborhood = clientDTO.Neighborhood;
                clientVM.Street = clientDTO.Street;
            }
            return View(clientVM);
        }

        [HttpPost]
        public ActionResult Edit(ClientVM clientVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                ClientDTO clientDTO = new ClientDTO
                {
                    Id = clientVM.Id,
                    Name = clientVM.Name,
                    Age = clientVM.Age,
                    Email = clientVM.Email,
                    Number = clientVM.Number,
                    City = clientVM.City,
                    Neighborhood = clientVM.Neighborhood,
                    Street = clientVM.Street
                };
                service.PutClient(clientDTO);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                service.DeleteClient(id);
            }
            return RedirectToAction("Index");
        }
    }
}