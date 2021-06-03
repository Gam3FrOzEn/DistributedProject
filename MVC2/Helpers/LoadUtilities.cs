using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Helpers
{
    public class LoadUtilities
    {
        public static SelectList LoadHotDogData()
        {
            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                return new SelectList(service.GetHotDogs(""), "Id", "Title");
            }
        }

        public static SelectList LoadClientData()
        {
            using (MVC2.ServiceReference1.Service1Client service = new MVC2.ServiceReference1.Service1Client())
            {
                return new SelectList(service.GetClients(""), "Id", "Name");
            }
        }
    }
}