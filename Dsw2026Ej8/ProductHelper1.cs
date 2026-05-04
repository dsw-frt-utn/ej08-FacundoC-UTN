
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //Partial para dividir la clase en 2 
    public partial class ProductHelper
    {
        // Este es el método principal que pide el problema
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            // Aquí llamamos a un método auxiliar que esta en la segunda parte.
            
            return FormatearEtiqueta(code, description, price);
        }
    }
}