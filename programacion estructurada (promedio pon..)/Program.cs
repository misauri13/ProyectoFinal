using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_estructurada__promedio_pon._._
{
    class Program
    {
        static void Main(string[] args)
        {

            string SALIDA = "";
            Console.WriteLine(SALIDA.ToString());




            decimal crePRI = 0;
            Console.WriteLine(crePRI.ToString());

            decimal creSEG = 0;
            Console.WriteLine(creSEG.ToString());

            decimal creTER = 0;
            Console.WriteLine(creTER.ToString());

            decimal creCUAR = 0;
            Console.WriteLine(creCUAR.ToString());

            decimal creQUIN = 0;
            Console.WriteLine(creQUIN.ToString());

            decimal creSEX = 0;
            Console.WriteLine(creSEX.ToString());

            decimal creSEP = 0;
            Console.WriteLine(creSEP.ToString());





            decimal caliPRI = 0;
            Console.WriteLine(caliPRI.ToString());

            decimal caliSEG = 0;
            Console.WriteLine(caliSEG.ToString());

            decimal caliTER = 0;
            Console.WriteLine(caliTER.ToString());

            decimal caliCUAR = 0;
            Console.WriteLine(caliCUAR.ToString());

            decimal caliQUIN = 0;
            Console.WriteLine(caliQUIN.ToString());

            decimal caliSEX = 0;
            Console.WriteLine(caliSEX.ToString());

            decimal caliSEP = 0;
            Console.WriteLine(caliSEP.ToString());






            decimal SUMADETODOSLOSCREDITOS = 0;
            Console.WriteLine(SUMADETODOSLOSCREDITOS.ToString());

            decimal PP = 0;
            Console.WriteLine(PP.ToString());











            string lector = "";
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("----BIENVENIDO AL SISDEMA DE CALCULO DE PROMEDIO PONDERADO (SCPP) SECCION 0463-----------");
            Console.WriteLine("----MISAURY DE LOS SANTOS                  17--EIIN--1--008------------------------------");
            Console.WriteLine("----GREGORY LUNA                           17--EIIN--1--008------------------------------");
            Console.WriteLine("----ORIDITO MONTERO                        17--EIIN--1--008------------------------------");
            Console.WriteLine("----WILFREDDY DURAN                        17--EIIN--1--008------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("..USO DEL PROGRAMA:.........................este programa esta diseñado para buscar el promedio ponderado  de 7");
            Console.WriteLine("..materias y sus 7 creditos, si utilizaras una cantidad menor a 7  materias con sus creditos es necesario llenar ");
            Console.WriteLine("..los creditos y materias sobrantes  con el numero (0) para que puedas obterner tu promedio ponderado con exito..");










            Console.WriteLine(" DIGITE LOS CREDITOS DE LA PRIMERA MATERIA   ");
            lector = Console.ReadLine();
            crePRI = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA PRIMERA MATERIA   ");
            lector = Console.ReadLine();
            caliPRI = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE LOS CREDITOS DE LA SEGUNDA MATERIA   ");
            lector = Console.ReadLine();
            creSEG = Convert.ToDecimal(lector);


            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA SEGUNDA MATERIA MATERIA   ");
            lector = Console.ReadLine();
            caliSEG = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE LOS CREDITOS DE LA TERCERA MATERIA   ");
            lector = Console.ReadLine();
            creTER = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA TERCERA MATERIA   ");
            lector = Console.ReadLine();
            caliTER = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE LOS CREDITOS DE LA CUARTA MATERIA   ");
            lector = Console.ReadLine();
            creCUAR = Convert.ToDecimal(lector);


            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA CUARTA MATERIA    ");
            lector = Console.ReadLine();
            caliCUAR = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE LOS CREDITOS DE LA QUINTA MATERIA   ");
            lector = Console.ReadLine();
            creQUIN = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA QUINTA MATERIA   ");
            lector = Console.ReadLine();
            caliQUIN = Convert.ToDecimal(lector);

            Console.WriteLine(" DIGITE LOS CREDITOS DE LA SEXTA MATERIA   ");
            lector = Console.ReadLine();
            creSEX = Convert.ToDecimal(lector);


            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA SEXTA  MATERIA   ");
            lector = Console.ReadLine();
            caliSEX = Convert.ToDecimal(lector);


            Console.WriteLine(" DIGITE LOS CREDITOS DE LA SEPTIMA MATERIA   ");
            lector = Console.ReadLine();
            creSEP = Convert.ToDecimal(lector);


            Console.WriteLine(" DIGITE la calificacion OBTENIDA EN LA SEPTIMA  MATERIA   ");
            lector = Console.ReadLine();
            caliSEP = Convert.ToDecimal(lector);






            SUMADETODOSLOSCREDITOS = crePRI + creSEG + creTER + creCUAR + creQUIN + creSEX + creSEP;


            PP = (crePRI * caliPRI + creSEG * caliSEG + creTER * caliTER + creCUAR * caliCUAR + creQUIN * caliQUIN + creSEX * caliSEX + creSEP * caliSEP) / SUMADETODOSLOSCREDITOS;

            Console.WriteLine("SU PROMEDIO PORCENTUAL ES: " + PP.ToString());
            Console.ReadKey();
        }
    }
}
