using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class SaleDTO
    {
        public int Id { get; set; }
        public byte Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal FinalPrice { get; set; }
        public int HotDogId { get; set; }
        public int ClientId { get; set; }
        public HotDogDTO HotDog { get; set; }
        public ClientDTO Client { get; set; }
    }
}
