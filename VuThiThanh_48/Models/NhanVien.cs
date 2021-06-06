using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuThiThanh_48.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien{ get; set; }
        public string TenNhanVien{ get; set; }
        public int MaTinhThanh{ get; set; }
        public virtual TinhThanh TinhThanh { get; set; }
    }
}