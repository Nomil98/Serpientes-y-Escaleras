using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Escaleras
{
    class Jugador
    {
        private int _NumeroJugador;
        private int _Posicion;

        public int NumeroJugador
        {
            get { return _NumeroJugador; }

        }
        public int Posicion
        {
            get { return _Posicion; }
        }
        public  Jugador(int NumeroJugador)
        {
            _NumeroJugador = NumeroJugador;
            _Posicion = 0;
        }

        public void avance (int Dado)
        {
            _Posicion += Dado;
        }

        public override string ToString()
        {
            return "Jugador Número"+ NumeroJugador.ToString() + "Se encuentra en la posición " +  Posicion.ToString();
        }

    }
}
