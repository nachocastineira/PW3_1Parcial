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
        public int bases;

        [Required]
        [Range(1, 99)]
        public int altura;

        public string tipoFigura;
        public int resultado;
    }
}