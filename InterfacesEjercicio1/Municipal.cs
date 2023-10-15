using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Municipal:Impuesto
    {
        private int partida;
        public Municipal(int partida, double importe):base(importe)
        {
            this.partida = partida;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Impresion de Impuestos Municipales nº {partida} por el total de ${importe}");
        }
    }
}
