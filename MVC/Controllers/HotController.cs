using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HotController : Controller
    {
        private readonly Uri url = new Uri("https://localhost:44339/api/hotDog/");

        // GET: Hot
        public async Task<ActionResult> Index()
        {

            using (var client = new HttpClient())
            {

                client.BaseAddress = url;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage response = await client.GetAsync("");


                string jsonString = await response.Content.ReadAsStringAsync();
                var responseData = JsonConvert.DeserializeObject<List<HotDogVM>>(jsonString);

                return View(responseData);
            }

        }
        public async Task<ActionResult> Details(int id)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = url;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage response = await client.GetAsync(""+id);


                string jsonString = await response.Content.ReadAsStringAsync();
                var responseData = JsonConvert.DeserializeObject<HotDogVM>(jsonString);

                return View(responseData);
            }
        }

        // Get HotDog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST HotDog/Create
        [HttpPost]
        public async Task<ActionResult> Create(HotDogVM hotDogVM)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // prepare request
                    client.BaseAddress = url;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // add data to rquest
                    var content = JsonConvert.SerializeObject(hotDogVM);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // make request
                    HttpResponseMessage response = await client.PostAsync("", byteContent);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = url;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await client.DeleteAsync("" + id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}