using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //Extension como su nombre indica permite modificar o agregar sin modificar la clase original
    public static class Extensions
    {
        // This como forma de aclaracion de que los textos string tendran ese metodo
        public static string ToProductCode(this string code)
        {
            if (code == null) return "SIN-CODIGO";

            // .Trim() borra espacios a los costados
            // .ToUpper() lo hace mayúscula.
            string normalizado = code.Trim().ToUpper();

            // Esto reemplaza cualquier espacio en el medio por un guion.
            string[] partes = normalizado.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("-", partes);
        }
    }
}
