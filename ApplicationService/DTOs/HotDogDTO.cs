using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.HotDog;

namespace ApplicationService.DTOs
{
    public class HotDogDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Sauce { get; set; }

        public string Spice { get; set; }

        public decimal Price { get; set; }

        public Sausage SausageType { get; set; }

        public Bun BunType { get; set; }
    }
}
