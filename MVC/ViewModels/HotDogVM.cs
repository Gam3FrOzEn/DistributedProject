using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class HotDogVM
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Sauce { get; set; }

        public string Spice { get; set; }

        [Required]
        public decimal Price { get; set; }

        public enum Sausage { pork, beef, chicken }

        [Required]
        public Sausage SausageType { get; set; }

        public enum Bun { white, wheat, rye }

        [Required]
        public Bun BunType { get; set; }

        public HotDogVM() { }

        public HotDogVM(HotDogDTO hotDogDTO)
        {
            Id = hotDogDTO.Id;
            Title = hotDogDTO.Title;
            Sauce = hotDogDTO.Sauce;
            Spice = hotDogDTO.Spice;
            Price = hotDogDTO.Price;
            SausageType = (Sausage)hotDogDTO.SausageType;
            BunType = (Bun)hotDogDTO.BunType;


        }
    }
}