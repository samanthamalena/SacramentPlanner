using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Sacrament
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Conducting { get; set; }
        public string OpenHymn { get; set; }
        public string OpenPrayer { get; set; }
        public string SacramentHymn { get; set; }
        public string Speaker { get; set; }
        public string Subject { get; set; }
        public string CloseHymn { get; set; }
        public string ClosePrayer { get; set; }
    }
}
