using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuThiThanh_48.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key]
        public  int MaTinhThanh { get; set; }
        public String TenTinhThanh { get; set; }
    }
}