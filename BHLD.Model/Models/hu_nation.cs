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
    [Table("hu_nation")]
    public class hu_nation: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(255)]
        public string nation_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
