using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Remito:Iimprimible
    {
        private int cantBultos;
        private DateTime fecha;
        private int numero;

        public Remito(int cantBultos, int numero)
        {
            this.cantBultos = cantBultos;
            fecha = DateTime.Now;
            this.numero = numero;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Impresion de Remito: {numero} con {cantBultos} del dia {fecha}");
        }
    }
}
