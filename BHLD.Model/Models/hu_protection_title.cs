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

    [Table("hu_protection_title")]
    public class hu_protection_title : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        //tham chiếu phần other_list_type
        //[ForeignKey("type_id")]
        
        [Required]
        [ForeignKey("title_id")]
        public int type_id { get; set; }
        [Required]
        public DateTime effect_date { get; set; }
        [Required]
        public DateTime expire_date { get; set; }
        [StringLength(1023)]
        public string remark { get; set; }
        

    }
}
