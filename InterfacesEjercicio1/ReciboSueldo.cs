using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class ReciboSueldo: Iimprimible
    {
        protected int legajo;
        protected double total;
        public ReciboSueldo(int legajo, double total) {
            this.legajo = legajo;
            this.total = total;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Impresion de Recibo de sueldo de: {legajo} con el total: ${total}");
        }
    }
}
