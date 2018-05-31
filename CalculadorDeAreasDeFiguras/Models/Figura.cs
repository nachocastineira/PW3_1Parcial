using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalculadorDeAreasDeFiguras.Models
{
    public class Figura
    {
        [Required]
        [Range(1, 99)]
        public int bases { get; set; }

        [Required]
        [Range(1, 99)]
        public int altura { get; set; }

        public string tipoFigura { get; set; }

        public int resultado { get; set; }
    }
}