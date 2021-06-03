using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Sale : BaseEntity
    {
        [Required]
        public byte Quantity { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal FinalPrice { get; set; }

        [Required]
        public int HotDogId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey("HotDogId")]
        public HotDog HotDog { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
