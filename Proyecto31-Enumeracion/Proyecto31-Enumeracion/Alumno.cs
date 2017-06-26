using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto31_Enumeracion
{
    public enum Sexo : int
    {
        Masculino,
        Femenino
    }
    
    public class Alumno
    {
        private string nombre;
        private int semestre;
        private int edad;
        private Sexo sexo;

        public Alumno(string nombre, int semestre, int edad, Sexo sexo)
        {
            this.nombre = nombre;
            this.semestre = semestre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            /* así en lugar del sexo devuelve el indice (0 en el caso de masculino, 1 en el otro) */
            //return String.Format("{0} {1} {2} {3}", nombre, semestre, edad, (int)sexo);
            return String.Format("{0} {1} {2} {3}", nombre, semestre, edad, sexo);
        }
    }
}
