using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InterfacesEjercicio1
{
    internal  abstract class DocumentoContable : Iimprimible
    {
        protected DateTime fecha;
        protected double importe;
        protected int numero;
        protected string sigla;

        public DocumentoContable(string sigla, int numero, double importe)
        {
            fecha = DateTime.Now;
            this.sigla = sigla;
            this.numero = numero;
            this.importe = importe;
        }
        public DateTime getFecha() { return fecha; }
        public void setFecha(DateTime fecha) { this.fecha = fecha; }
        
        public double getImporte() { return importe; }
        public void setImporte(double importe) { this.importe = importe; }
        
        public int getNumero() { return numero; }
        public void setNumero(int numero) { this.numero = numero; }
        
        public string getSigla() { return sigla; }
        public void setSigla(string sigla) { this.sigla = sigla; }

        public  void Imprimir()
        {
            Console.WriteLine($"Impresion de {sigla} de ${total()} del dia {fecha}");
        }
        public abstract double total();
        
    }
}
