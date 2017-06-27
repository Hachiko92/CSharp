using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proyecto29_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList miLista = new ArrayList();
            miLista.Add("Hola");
            miLista.Add(" desde ");
            miLista.Add("Array List");

            foreach (string frase in miLista)
            {
                Console.Write(frase);
            }

            Console.WriteLine("\n\nLa segunda es: \"{0}\"\n", miLista[1]);

            miLista.Insert(1, " otra palabra");

            foreach (string frase in miLista)
            {
                Console.Write(frase);
            }

            miLista.Sort();

            Console.WriteLine("\n\nOrdenado:\n");
            foreach (string frase in miLista)
            {
                Console.WriteLine(frase);
            }

            miLista.Reverse();

            Console.WriteLine("\nOrdenado al revés:\n");
            foreach (string frase in miLista)
            {
                Console.WriteLine(frase);
            }

            miLista.RemoveAt(1);
            miLista.Remove("Hola");

            Console.WriteLine("\nEliminando el elemento a la segunda posicion y \"Hola\":\n");
            foreach (string frase in miLista)
            {
                Console.WriteLine(frase);
            }
            #endregion

            #region SortedList
            SortedList miDiccionario = new SortedList();
            /* es como un array pero con la posibilidad de dar además indices numericos o de palabras etc */
            /* indice y valor indice */
            /* clave y valor*/
            miDiccionario.Add("hello", "hola");
            miDiccionario.Add("home", "casa");

            Console.WriteLine("\nSortedList\n");

            Console.WriteLine(miDiccionario.GetByIndex(0));
            Console.WriteLine(miDiccionario.GetByIndex(miDiccionario.IndexOfKey("hello")));
            /* con "hola" no funcionaría */
            //Console.WriteLine(miDiccionario.GetByIndex(miDiccionario.IndexOfKey("hola")));
            #endregion

            #region TablaHash
            Hashtable miDiccionario2 = new Hashtable();
            miDiccionario2.Add("Elemento1", "Este es el primer elemento");
            miDiccionario2.Add("casa", "Lugar para vivir");

            Console.WriteLine("\nTabla Hash\n");

            Console.WriteLine(miDiccionario2["Elemento1"]);

            #endregion

            Console.ReadKey();
        }
    }
}
