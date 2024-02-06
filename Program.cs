using System.Globalization;
using System.Reflection;

namespace edu.PR.Ejercicio4._0502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String fecha;
            Console.WriteLine("Introduzca fecha de nacimiento: d/M/yyyy");
            fecha = Console.ReadLine();

            DateTime fechaUsuario = Convert.ToDateTime(fecha);
            Console.WriteLine(fechaUsuario.ToString());

            DateTime fechaHoy = DateTime.Now;

            int calculoAnio = fechaHoy.Year - fechaUsuario.Year;
            Console.WriteLine(calculoAnio.ToString());

            int calculoMes = fechaHoy.Month - fechaUsuario.Month;
            Console.WriteLine(calculoMes.ToString());

            int calculoDia = fechaHoy.Day - fechaUsuario.Day;
            Console.WriteLine(calculoDia.ToString());

            if (calculoAnio > 0)
            {
               

                if(calculoMes < 0)
                {
                    calculoAnio = calculoAnio - 1;
                    Console.WriteLine("La edad actual es de:  " + calculoAnio);
                }
                else
                {
                    if(calculoDia < 0)
                    {
                        calculoAnio = calculoAnio - 1;
                        Console.WriteLine("La edad actual es de:  " + calculoAnio);
                    }
                
                    else
                    {
                        if (calculoDia == 0 ) {
                            
                            Console.WriteLine("Es tu cumpleaños, cumples: " + calculoAnio);
                        }
                       
                    }
       
                }
            }
            else
            {
                Console.WriteLine("La fecha indicada es más alta que la fecha actual");
            }


        }

    }
}