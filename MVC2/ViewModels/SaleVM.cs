using ApplicationService.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class SaleVM
    {
        public int Id { get; set; }

        [Required]
        public byte Quantity { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Time)]
        public DateTime Date { get; set; }
        //[DataType(DateTime)]

        public decimal FinalPrice { get; set; }

        [Required]
        public int HotDogId { get; set; }

        [Required]
        public int ClientId { get; set; }


        public HotDogVM HotDogVM { get; set; }


        public ClientVM ClientVM { get; set; }

        public SaleVM() { }

        public SaleVM(SaleDTO saleDTO)
        {
            Id = saleDTO.Id;
            Quantity = saleDTO.Quantity;
            Date = saleDTO.Date;
            FinalPrice = saleDTO.FinalPrice;
            HotDogId = saleDTO.HotDogId;
            ClientId = saleDTO.ClientId;

            HotDogVM = new HotDogVM
            {
                Id = saleDTO.HotDogId,

                //Id = saleDTO.HotDog.Id,
                Title = saleDTO.HotDog.Title,
                Sauce = saleDTO.HotDog.Sauce,
                Spice = saleDTO.HotDog.Spice,
                Price = saleDTO.HotDog.Price,
                SausageType = (HotDogVM.Sausage)saleDTO.HotDog.SausageType,
                BunType = (HotDogVM.Bun)saleDTO.HotDog.BunType
            };
            ClientVM = new ClientVM
            {
                Id = saleDTO.ClientId,
                //Id = saleDTO.Client.Id,
                Name = saleDTO.Client.Name,
                Age = saleDTO.Client.Age,
                Email = saleDTO.Client.Email,
                Number = saleDTO.Client.Number,
                City = saleDTO.Client.City,
                Neighborhood = saleDTO.Client.Neighborhood,
                Street = saleDTO.Client.Street
            };
        }
    }
}