using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            // 1. Copiamos el número. 
    
            int copiaValue = originalValue;
            copiaValue++; 

            // Copiamos el producto 
         
            Product copiaReferencia = product;

            // Si modificamos la copia, la original tambien lo hace
            copiaReferencia.ActualizarDescripcion(copiaReferencia.Description + " Modificado");

            // Devolvemos el texto como pide el problema
            return $"{originalValue}-{copiaValue}-{product.Description}";
        }
    }
}
