using BibliotecaAjedrez.Entidades.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAjedrez.Entidades
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se mueve horizontal y verticalmente.";
        }
    }
}
