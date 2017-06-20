using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21_Base
{
    class Coordenadas
    {
        private int x, y;

        public Coordenadas()
        {
            x = 0;
            y = 0;
        }
        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return (String.Format("({0},{1})", x, y));
            //return base.ToString();
        }
    }
}
