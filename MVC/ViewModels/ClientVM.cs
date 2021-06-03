using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ClientVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }

        public HotDogVM HotDogVM { get; set; }
        public ClientVM() { }

        public ClientVM(ClientDTO clientDTO)
        {
            Id = clientDTO.Id;
            Name = clientDTO.Name;
            Age = clientDTO.Age;
            Email = clientDTO.Email;
            Number = clientDTO.Number;
            City = clientDTO.City;
            Neighborhood = clientDTO.Neighborhood;
            Street = clientDTO.Street;
            
        }
    }
}