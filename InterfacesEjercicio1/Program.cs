using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NotaCredito unaNotaCredito = new NotaCredito("NC-A", 00001, 1500);
            //Factura unaFactura = new Factura("F-A", 00001, 1500);
            //unaImpresora.Imprimir(unaFactura);
            //unaImpresora.Imprimir(unaNotaCredito);
            //FacturaLuz facturaLuz1 = new FacturaLuz(0101, 13580);
            //unaImpresora.Imprimir(facturaLuz1);
            //Municipal Municipal1 = new Municipal(444, 9899);
            //unaImpresora.Imprimir(Municipal1);
            //ReciboSueldo ReciboSueldo1 = new ReciboSueldo(212, 87654.5);
            //unaImpresora.Imprimir(ReciboSueldo1);
            //Remito Remito1 = new Remito(18, 069);
            //unaImpresora.Imprimir(Remito1);

            Impresora unaImpresora = new Impresora();
            Console.WriteLine(" SISTEMA DE FACTURACIÓN E IMPRESIÓN ");
            Console.WriteLine("Ingrese una opción a continuación: ");
            Console.WriteLine("Para imprimir factura presione 1 ");
            Console.WriteLine("Para Nota de Crédito presione 2 ");
            Console.WriteLine("Para Recibo de Sueldo presione 3 ");
            Console.WriteLine("Para Remito presione 4 ");
            Console.WriteLine("Para Factura de Lux presione 5 ");
            Console.WriteLine("Para Impuestos municipales presione 6 ");
            Console.WriteLine("Si desea salir presione 0 ");

            bool esNumero;
            int seleccion;

            do
            {
                esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                if (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5 && seleccion != 6))
                {
                    Console.WriteLine("Incorrecto, vuelva a ingresar.");
                }
            } while (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5 && seleccion != 6));
            Console.Clear();

            while (seleccion != 0)
            {
                if (seleccion == 1)
                {
                    Console.WriteLine("Ingrese importe de la factura: ");
                    double importe = double.Parse(Console.ReadLine());
                    Factura Factura1 = new Factura("A", 01, importe);
                    unaImpresora.Imprimir(Factura1);                    
                }
                else if (seleccion == 2)
                {
                    Console.WriteLine("Ingrese importe de la nota de crèdito: ");
                    double importe = Int32.Parse(Console.ReadLine());
                    NotaCredito notaCredito1 = new NotaCredito("N", 01, importe);
                    unaImpresora.Imprimir(notaCredito1);
                }
                else if (seleccion == 3)
                {
                    Console.WriteLine("Ingrese numero de legajo: ");
                    int legajo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese total de sueldo: ");
                    double totalSueldo = double.Parse(Console.ReadLine());
                    ReciboSueldo reciboSueldo1 = new ReciboSueldo(legajo, totalSueldo);
                    unaImpresora.Imprimir(reciboSueldo1);
                }
                else if (seleccion == 4)
                {
                    Console.WriteLine("Ingrese cantidad de bultos: ");
                    int cantidad = Int32.Parse(Console.ReadLine());
                    Remito remito1 = new Remito(cantidad, 01);
                    unaImpresora.Imprimir(remito1);
                }
                else if (seleccion == 5)
                {
                    Console.WriteLine("Ingrese Importe de la Factura de Luz: ");
                    double importe = double.Parse(Console.ReadLine());
                    FacturaLuz FacturaLuz1 = new FacturaLuz(96608, importe);
                    unaImpresora.Imprimir(FacturaLuz1);
                }
                else if (seleccion == 6)
                {
                    Console.WriteLine("Ingrese importe de los Impuestos Municipales: ");
                    double importe = double.Parse(Console.ReadLine());
                    Municipal municipal1 = new Municipal(224675, importe);
                    unaImpresora.Imprimir(municipal1);
                }
                
                Console.ReadKey();

                Console.WriteLine("Ingrese una opción a continuación: ");
                Console.WriteLine("Para imprimir factura presione 1 ");
                Console.WriteLine("Para Nota de Crédito presione 2 ");
                Console.WriteLine("Para Recibo de Sueldo presione 3 ");
                Console.WriteLine("Para Remito presione 4 ");
                Console.WriteLine("Para Factura de Lux presione 5 ");
                Console.WriteLine("Para Impuestos municipales presione 6 ");
                Console.WriteLine("Si desea salir presione 0 ");

                do
                {
                    esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                    if (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5 && seleccion != 6))
                    {
                        Console.WriteLine("Incorrecto, vuelva a ingresar.");
                    }
                } while (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5 && seleccion != 6));
               
                Console.Clear();
            }
        }
    }
}
