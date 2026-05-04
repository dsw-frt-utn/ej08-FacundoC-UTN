using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //Clase de apoyo para que tome de referencia el problema
    public class Product
    {
        public string Description { get; set; }

        public void ActualizarDescripcion(string nuevaDescripcion)
        {
            Description = nuevaDescripcion;
        }
    }
}
