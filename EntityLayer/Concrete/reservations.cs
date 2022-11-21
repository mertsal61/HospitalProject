using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservations
    {
        [Key]
        public int reservationId { get; set; }
        public string? reservationname { get; set; }
        public string? reservationdate { get; set; }
    }
}
