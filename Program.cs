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
            TimeSpan restaFechas = fechaHoy - fechaUsuario;
            
            int calculoAnio = fechaHoy.Year - fechaUsuario.Year;
            

            int calculoMes = fechaHoy.Month - fechaUsuario.Month;
          

            int calculoDia = fechaHoy.Day - fechaUsuario.Day;
          

            
    

            if (calculoAnio > 0)
            {


                if (calculoMes > 0)
                {
                    Console.WriteLine("años: " + calculoAnio);

                }
                else if (calculoMes < 0)
                {

                    int restaAnio = calculoAnio - 1;
                    Console.WriteLine("Años: " + restaAnio);

                }
                else if (calculoMes == 0)
                {
                    if (calculoDia > 0)
                    {
                        Console.WriteLine("Años: " + calculoAnio);
                    }
                    else if (calculoDia < 0)
                    {
                        int restaAnio = calculoAnio - 1;
                        Console.WriteLine("Años: " + restaAnio);

                    }
                    else if (calculoDia == 0)
                    {
                        Console.WriteLine("Es tu cumpleaños, cumples: " + calculoAnio);

                    }

                }


            }

            
            double resultadoDias = restaFechas.TotalDays;
            Console.WriteLine("calculo dias al completo: " + resultadoDias);
            int parteEnteraDias = (int)resultadoDias;
            Console.WriteLine("Parte entera de los dias: " + parteEnteraDias) ;
            double parteDecimalDias = resultadoDias - parteEnteraDias;
            Console.WriteLine("Parte decimal de los dias:" + parteDecimalDias) ;

            double resultadoMes = parteEnteraDias / 31.0;
            Console.WriteLine("calculo de meses al completo: " + resultadoMes) ;
            int parteEnteraMeses = (int)resultadoMes;
            Console.WriteLine("Parte entera de los meses: " + parteEnteraMeses) ;
           

            double resultadoAnio = parteEnteraMeses / 12.0;
            Console.WriteLine("calculo total de los años: " + resultadoAnio) ;
            int parteEnteraAnios = (int)resultadoAnio;
            Console.WriteLine("Parte entera de los años: " + parteEnteraAnios) ;
            



            Console.WriteLine("#############################");
            Console.WriteLine("AÑOS: " + parteEnteraAnios);
            double calculoMesesReal = parteEnteraMeses % 12.0;
            Console.WriteLine("MESES: " + calculoMesesReal);
            double calculoDiasReal = parteEnteraDias % 30.0;
            Console.WriteLine("Dias: " + calculoDiasReal);
            



        }

    }
}