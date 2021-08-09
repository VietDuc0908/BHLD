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
    [Table("hu_protection_setting")]
    public class hu_protection_setting :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        //giới tính
        public int gender { get; set; }
        //vòng bụng
        public int belly { get; set; }
        //vòng mông
        public int butt { get; set; }
        //đai quần
        public int belt { get; set; }
        //vòng ngực
        public int chest { get; set; }
        //rộng vai
        public int shoulder { get; set; }
        //size of Protection Gear
        [ForeignKey("size_id")]
        public int size_id { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }

}
