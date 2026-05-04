using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //Mismo nombre de clase para referenciar la primera parte
    public partial class ProductHelper
    {
      
        //Private pq lo usa esta clase solamente
        private string FormatearEtiqueta(long code, string description, decimal price)
        {
            
            return $"[{code}] {description} - {price:C}";
        }
    }
}