using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculadorDeAreasDeFiguras.Models;

namespace CalculadorDeAreasDeFiguras.Services
{
    public class CalculadorServices
    {
        public static List<Figura> resultados = new List<Figura>();

        public Figura CalcularCuadrado (Figura f)
        {
           f.tipoFigura = "Cuadrado";
           f.resultado = f.bases * f.altura;
            
           return f;
        }

        public Figura CalcularTriangulo (Figura f)
        {
            f.tipoFigura = "Triangulo";
            f.resultado = (f.bases * f.altura)/2;

            return f;
        }


        public void AgregarResultado (Figura f)
        {
            resultados.Add(f);
        }


         public List<Figura> Listar()
        {
            return resultados;
         
        }

    }
}