using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Sacrament
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

       // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
       // [Required]
       // [StringLength(50)]
        public string Conducting { get; set; }

        [Range(1, 341, ErrorMessage = "Please enter a valid hymn number")]
        [Display(Name = "Opening Hymn")]
        public int OpenHymn { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Opening Prayer")]
        public string OpenPrayer { get; set; }

        [Range(1, 341, ErrorMessage = "Please enter a valid hymn number")]
        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymn { get; set; }

        [Range(1, 341, ErrorMessage = "Please enter a valid hymn number")]
        [Display(Name = "Intermediate Hymn (optional)")]
        public int? IntermediateHymn { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(40)]
        public string Speaker { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(40)]
        public string Subject { get; set; }

        [Range(1, 341, ErrorMessage = "Please enter a valid hymn number")]
        [Display(Name = "Closing Hymn")]
        public int CloseHymn { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Closing Prayer")]
        public string ClosePrayer { get; set; }
    }
}
