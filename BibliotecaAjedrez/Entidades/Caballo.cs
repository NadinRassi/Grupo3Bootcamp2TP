using BibliotecaAjedrez.Entidades.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAjedrez.Entidades
{
    public class Caballo : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se mueve en L.";
        }
    }
}
