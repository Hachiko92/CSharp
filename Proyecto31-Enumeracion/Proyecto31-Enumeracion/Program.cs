using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto31_Enumeracion
{
    //enum diasSemana
    //{
    //    LUNES,MARTES,MIERCOLES,JUEVES,VIERNES,SABADO,DOMINGO
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("El dia de la semana es: {0}", diasSemana.MIERCOLES);
            //Console.WriteLine("que equivale a: {0}", (int)diasSemana.MIERCOLES);

            //Alumno alumno = new Alumno("Edison", 2, 23, Sexo.Masculino);
            //Console.WriteLine(alumno.ToString());

            /* ************************************************************ */

            string miDerectorio = @"C:\inetpub\CursoWeb\Dise-oWeb";

            /* si no existe este directorio lo crea */
            if (!Directory.Exists(miDerectorio))
            {
                Directory.CreateDirectory(miDerectorio);
            }

            string[] listaFicheros;
            listaFicheros = Directory.GetFiles(miDerectorio);

            foreach (string fichero in listaFicheros)
            {
                Console.WriteLine(fichero);
            }

            Console.WriteLine("\nNombre y data de creación de los ficheros\n");

            DirectoryInfo dir = new DirectoryInfo(miDerectorio);

            FileInfo[] infoFicheros = dir.GetFiles();
            foreach (FileInfo fichero in infoFicheros)
            {
                Console.WriteLine(fichero.Name);
                Console.WriteLine(fichero.CreationTime);
            }

            //Directory directorio = new Directory();

            Console.ReadKey();
        }
    }
}
