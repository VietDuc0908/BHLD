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
    [Table("se_user_report")]
    public class se_user_report:Auditable

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [ForeignKey("user_id")]
        public virtual se_user fk_se_user { get; set; }
        [ForeignKey("se_report_id")]
        public virtual se_report fl_se_report { get; set; }
    }
}
