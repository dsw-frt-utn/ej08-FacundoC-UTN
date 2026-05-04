using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            // Metemos las notas en una lista 
            int?[] notas = { nota1, nota2, nota3 };

            double suma = 0;
            int cantidadValidas = 0;

            // Revisamos cada nota
            foreach (var nota in notas)
            {
                // Preguntamos si tiene un valor y lo sacamos si es el caso
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value; // Sumamos la nota
                    cantidadValidas++;  // Contamos la nota valida
                }
            }

            // Si las 3 notas eran nulas o inválidas, devolvemos 0 para evitar errores matemáticos
            if (cantidadValidas == 0) return 0;

            // Calculamos el promedio
            return suma / cantidadValidas;
        }
    }
}
