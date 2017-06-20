using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto09_Matrice
{
    class Program
    {
        struct fechaNacimiento
        {
            public byte dia;
            public byte mes;
            public short año;
        }
        // la estructura tiene que estar fuera del main i con los campos publicos
        struct tipoPersona
        {
            public string nombre;
            public char inicial;
            public byte edad;
            public fechaNacimiento diaNacimiento;
            public float nota;
        }

        struct cancion
        {
            public string artista;
            public string titulo;
            public ushort duracion;
            public float tamanio;
        }

        static void Main(string[] args)
        {
            tipoPersona persona;

            persona.nombre = "Javier";
            persona.inicial = 'J';
            persona.edad = 23;
            persona.nota = 6.3f;

            persona.diaNacimiento.dia = 3;
            persona.diaNacimiento.mes = 12;
            persona.diaNacimiento.año = 1900;

            Console.WriteLine("La edad de {0} es {1}", persona.nombre, persona.edad);




            //// Ejercicio 1.21
            //cancion canzone;

            //Console.WriteLine("Insertar los datos de la cancion\n");

            //Console.Write("Artista: ");
            //canzone.artista = Console.ReadLine();
            //Console.Write("Titulo: ");
            //canzone.titulo = Console.ReadLine();
            //Console.Write("Duración en segundos de la canción: ");
            //canzone.duracion = Convert.ToUInt16(Console.ReadLine());
            //Console.Write("Dimensión en kb del fichero: ");
            //canzone.tamanio = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("\n{0} de {1} ({2} segundos, {3}kb)", canzone.titulo, canzone.artista, canzone.duracion, canzone.tamanio);

            //Console.ReadLine();

            //cancion[] canciones[] = new cancion[99];
            //canciones[0].artista = "Bob Dylan";


        }
    }
}
