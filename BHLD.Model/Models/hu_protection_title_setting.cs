using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Model.Models
{
    [Table("hu_protection_title_setting")]
    public class hu_protection_title_setting:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [ForeignKey("bhld_title_id")]
        public virtual hu_protection_title fk_hu_protection_title { get; set; }
        [Required]
        [ForeignKey("bhld_list_id")]
        public virtual hu_protection fk_hu_protection { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public DateTime? effect_date { get; set; }
        [Required]
        public DateTime? expire_date { get; set; }

    }
}
