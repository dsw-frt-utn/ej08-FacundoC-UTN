using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{

    // La clase padre , la venta general
    public abstract class Sale
    {
        public decimal MontoBase { get; set; }

        // Virtual, que los hijos puedan modificar como se hace el calculo
        public virtual decimal CalculateTotal()
        {
            return MontoBase;
        }
    }

    // Hija 1 , la venta minorista
    public class RetailSale : Sale
    {
        // Utilizamos override para cambiar la forma de hacer el calculo, en este caso quedo igual la forma
    
        public override decimal CalculateTotal()
        {
            return MontoBase;
        }
    }

    // Hija 2, venta mayorista
    public class WholesaleSale : Sale
    {
        // Utilizacion del override, en este caso si cambia la forma del calculo
        public override decimal CalculateTotal()
        {
            return MontoBase * 0.90m;
        }
    }

  

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            // Dependiendo que venta se haga, se utilizara el calculo adecuado
           
            return sale.CalculateTotal();
        }
    }
}