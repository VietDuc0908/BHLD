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
    [Table("se_user_org_access")]
    public class se_user_org_access : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [ForeignKey("user_id")]
        public virtual hu_employee fk_hu_employee { get; set; }
        [ForeignKey("org_id")]
        public virtual hu_organization fk_hu_organization { get; set; } //khóa ngoại với bảng đơn vị
    }
}
