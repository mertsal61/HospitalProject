using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reports
    {
        [Key]
        public int reportId { get; set; }
        public string? reportname { get; set; }
        public string? reportdate { get; set; }
    }
}
