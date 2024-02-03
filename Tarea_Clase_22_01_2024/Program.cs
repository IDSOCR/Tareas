using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Clase_22_01_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir datos al usuario
            Console.WriteLine("*Programa de Planilla*");
            Console.Write("Ingrese número de cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de horas laboradas: ");
            int horasLaboradas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio por hora: ");
            decimal precioHora = decimal.Parse(Console.ReadLine());

            // Calcular salario ordinario
            decimal salarioOrdinario = horasLaboradas * precioHora;

            // Calcular aumento
            decimal aumento = 0;
            switch (tipoEmpleado)
            {
                case 1:
                    aumento = salarioOrdinario * 0.15m;
                    break;
                case 2:
                    aumento = salarioOrdinario * 0.10m;
                    break;
                case 3:
                    aumento = salarioOrdinario * 0.05m;
                    break;
            }

            // Calcular salario bruto
            decimal salarioBruto = salarioOrdinario + aumento;

            // Calcular deducciones
            decimal deduccionesCCSS = salarioBruto * 0.0917m;

            // Calcular salario neto
            decimal salarioNeto = salarioBruto - deduccionesCCSS;

            // Mostrar resultados
            Console.WriteLine("\n*Resultados*");
            Console.WriteLine("Cédula: {0}", cedula);
            Console.WriteLine("Nombre Empleado: {0}", nombre);
            Console.WriteLine("Tipo Empleado: {0}", tipoEmpleado == 1 ? "Operario" : tipoEmpleado == 2 ? "Técnico" : "Profesional");
            Console.WriteLine("Salario por Hora: {0:C}", precioHora);
            Console.WriteLine("Cantidad de Horas: {0}", horasLaboradas);
            Console.WriteLine("Salario Ordinario: {0:C}", salarioOrdinario);
            Console.WriteLine("Aumento: {0:C}", aumento);
            Console.WriteLine("Salario Bruto: {0:C}", salarioBruto);
            Console.WriteLine("Deducción CCSS: {0:C}", deduccionesCCSS);
            Console.WriteLine("Salario Neto: {0:C}", salarioNeto);


        }
    }
}
