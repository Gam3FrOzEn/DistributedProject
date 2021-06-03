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
    public class HotDogController : Controller
    {
        // GET: HotDog
        public ActionResult Index(string Search_Data = "")
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            List<HotDogVM> hotDogsVM = new List<HotDogVM>();

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                foreach (var item in service.GetHotDogs(Search_Data))
                {
                    hotDogsVM.Add(new HotDogVM(item));
                }
            }

            return View(hotDogsVM);
        }

        public ActionResult Details(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            HotDogVM hotDogVM = new HotDogVM();

            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                var hotDogDTO = service.GetHotDogByID(id);
                hotDogVM = new HotDogVM(hotDogDTO);
            }
            return View(hotDogVM);
        }

        public ActionResult Create(HotDogVM hotDogVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            try
            {
                if (ModelState.IsValid)
                {
                    using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
                    {
                        HotDogDTO hotDogDTO = new HotDogDTO
                        {
                            Title = hotDogVM.Title,
                            Sauce = hotDogVM.Sauce,
                            Spice = hotDogVM.Spice,
                            Price = hotDogVM.Price,
                            SausageType = (Data.Entities.HotDog.Sausage)hotDogVM.SausageType,
                            BunType = (Data.Entities.HotDog.Bun)hotDogVM.BunType
                        };
                        service.PostHotDog(hotDogDTO);

                        return RedirectToAction("Index");
                    }
                }
                return View();
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

            HotDogVM hotDogVM = new HotDogVM();
            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                HotDogDTO hotDogDTO = service.GetHotDogByID(id);
                hotDogVM.Id = hotDogDTO.Id;
                hotDogVM.Title = hotDogDTO.Title;
                hotDogVM.Sauce = hotDogDTO.Sauce;
                hotDogVM.Spice = hotDogDTO.Spice;
                hotDogVM.Price = hotDogDTO.Price;
                hotDogVM.SausageType = (HotDogVM.Sausage)hotDogDTO.SausageType;
                hotDogVM.BunType = (HotDogVM.Bun)hotDogDTO.BunType;
            }
            return View(hotDogVM);
        }

        [HttpPost]
        public ActionResult Edit(HotDogVM hotDogVM)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                HotDogDTO hotDogDTO = new HotDogDTO
                {
                    Id = hotDogVM.Id,
                    Title = hotDogVM.Title,
                    Sauce = hotDogVM.Sauce,
                    Spice = hotDogVM.Spice,
                    Price = hotDogVM.Price,
                    SausageType = (Data.Entities.HotDog.Sausage)hotDogVM.SausageType,
                    BunType = (Data.Entities.HotDog.Bun)hotDogVM.BunType
                };
                service.PutHotDog(hotDogDTO);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            if (!AccountController.loggedIn)
                return RedirectToAction("Login", "Account");

            using (MVC2.SOAPService.Service1Client service = new MVC2.SOAPService.Service1Client())
            {
                service.DeleteHotDog(id);
            }
            return RedirectToAction("Index");
        }
    }
}
