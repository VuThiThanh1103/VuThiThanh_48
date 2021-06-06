using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VuThiThanh_48.Models
{
    public class TaiKhoan
    {
        [Required(ErrorMessage = "Username is required")]
        public String Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}