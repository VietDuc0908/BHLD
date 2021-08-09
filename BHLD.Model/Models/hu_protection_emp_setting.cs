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
    [Table("hu_protection_emp_setting")]
    public class hu_protection_emp_setting :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [ForeignKey("id_emp")]
        public virtual hu_protection_emp fk_hu_protection_emp { get; set; }
        [ForeignKey("bhld_list_id")]
        public virtual hu_protection fk_hu_protection { get;set;}
        public int amount{ get; set; }
    }
}
