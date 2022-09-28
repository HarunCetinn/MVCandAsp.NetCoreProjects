using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Departmanlar
    {
        [Key]
        public int Id { get; set; }
        public string DepartmanAd { get; set; }

        public List<Personel> personels { get; set; }
    }
}
