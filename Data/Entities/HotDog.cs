using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class HotDog : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        public string Title { get; set; }

        [MaxLength(20)]
        public string Sauce { get; set; }

        [MaxLength(12)]
        public string Spice { get; set; }

        [Required]
        public decimal Price { get; set; }

        public enum Sausage { pork, beef, chicken}
        [Required]
        public Sausage SausageType { get; set; }

        public enum Bun { white, wheat, rye }
        [Required]
        public Bun BunType { get; set; }


        //hgjh
    }
}
