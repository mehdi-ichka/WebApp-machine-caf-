using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_Adneom.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [Required]
        public string Boisson { get; set; }

        public bool WithMug { get; set; }

        public int QuantiteSucre { get; set; } // 1: faible, 2:moyen, 3:élevé
    }
    

}