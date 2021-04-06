using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVVC_Forms.Models
{
    public class PersonModel
    {   
        [Key]
        [Required]
        [StringLength(30)]
        public string name { get; set; }
        [Required]
        [Range(18,60)]
        public int age { get; set; }
        [Required]
        [StringLength(50)]
        public string address { get; set; }
        [Required]
        public int contact { get; set; }
        [Required]
        public DateTime birthday { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string ethnicity { get; set; }

    }
}
