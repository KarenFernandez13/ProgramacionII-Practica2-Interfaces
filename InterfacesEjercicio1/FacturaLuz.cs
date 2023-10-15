using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class FacturaLuz: Impuesto
    {
        private int codigoPago;

        public FacturaLuz(int codigoPago, double importe):base(importe) 
        {
            this.codigoPago = codigoPago;
        }
        public override void Imprimir()
        {
            Console.WriteLine($"Impresion de factura de luz {codigoPago} por el total de: ${importe}");
        }
    }
}
