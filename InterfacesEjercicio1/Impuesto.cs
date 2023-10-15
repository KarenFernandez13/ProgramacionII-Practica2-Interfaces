using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal abstract class Impuesto: Iimprimible
    {
        protected double importe;

        public Impuesto(double importe)
        {
            this.importe = importe;
        }

        public abstract void Imprimir();
    }
}
