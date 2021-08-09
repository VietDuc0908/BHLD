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
    [Table("hu_province")]
    public class hu_province : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(255)]
        public string province_name { get; set; }

        //Mã quốc gia
        //[ForeignKey("nation_id")]
        public int nation_id { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
