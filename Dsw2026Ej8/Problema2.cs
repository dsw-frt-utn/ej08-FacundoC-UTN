using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            
            // Si la cantidad es mayor a 0, multiplicamos. Si no, es 0.
            decimal totalCalculado = quantity > 0 ? quantity * unitPrice : 0;

            // 2. Aquí creamos la clase anonima, declarandolo con var
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };

            // 3. Armamos el texto final sacando los datos de la clase anonima
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}