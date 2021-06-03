using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BaseEntity
    {
        [Key] // validira i formatira id da ni e kluch kato primary
        public int Id { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; } // ? tq e za da ne e zaduljitelno poleto

        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
