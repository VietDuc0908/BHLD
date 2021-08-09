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
    [Table("ot_other_list")]
    public class ot_other_list: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [StringLength(50)]
        public string code { get; set; }


        //Tên size ủng/boots size
        //eg: 36,37,38,...
        [StringLength(255)]
        public string name { get; set; }


        //tham chiếu phần other_list_type
        //[ForeignKey("type_id")]
        public int type_id { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
