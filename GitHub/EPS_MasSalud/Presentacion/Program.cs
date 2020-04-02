using System;
using BLL;
using Entity;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string id;
            string tipo;
            decimal salario;
            decimal valor;
            LiquidacionCuotaModeradora liquidacion;
            ConsoleKeyInfo opcion;
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            do
            {
                try
                {
                    Console.WriteLine("BIENVENIDOS");
                    Console.WriteLine("Digite el numero de la liquidacion:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite la identificacion de paciente:");
                    id = Console.ReadLine();
                    Console.WriteLine("Digite el tipo de afiliacion:");
                    tipo = Console.ReadLine();
                    Console.WriteLine("Digite el salario devengado del paciente:");
                    salario = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite el valor del servicio:");
                    valor = Convert.ToDecimal(Console.ReadLine());
                    liquidacion = service.CrearCuota(tipo);
                    liquidacion.NumeroLiquidacion = numero;
                    liquidacion.IdentificacionPaciente = id;
                    liquidacion.TipoAfiliado = tipo;
                    liquidacion.SalarioDevengado = salario;
                    liquidacion.ValorServicioPrestado = valor;
                    liquidacion.CalcularCuota();
                    Console.WriteLine(service.Registrar(liquidacion));
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error " + e.Message);
                }
                Console.WriteLine("Desea continuar? S/N");
                opcion = Console.ReadKey();
            } while (opcion.Key == ConsoleKey.S);
            Console.Clear();
            Console.WriteLine("-------CONSULTA DE CUOTAS-------");
            foreach (var item in service.Consultar())
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------ELIMINAR CUOTA-------");
            Console.WriteLine("Digite el numero de la cuota a eliminar");
            int numeroEli = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(service.Eliminar(numeroEli));
            Console.WriteLine("-------CONSULTA DE CUOTAS-------");
            foreach (var item in service.Consultar())
            {
                Console.WriteLine(item.ToString());
            }
            Console.Clear();
            Console.WriteLine("-------MODIFICAR CUOTA-------");
            Console.ReadKey();
        }
    }
}
