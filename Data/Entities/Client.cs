using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        public byte Age { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Number { get; set; }

        [Required]
        [MaxLength(12)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string Neighborhood { get; set; }

        [Required]
        [MaxLength(30)]
        public string Street { get; set; }
    }
}
