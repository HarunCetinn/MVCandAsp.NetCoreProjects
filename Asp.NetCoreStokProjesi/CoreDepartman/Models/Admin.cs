using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartman.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName ="Varchar(20)")]
        public string Kullanıcı { get; set; }
        [Column(TypeName = "Varchar(10)")]
        public string Şifre { get; set; }





    }
}
