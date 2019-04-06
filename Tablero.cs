using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Escaleras
{
    class Tablero
    {
        protected int[] tablero = new int[100+1];
     


        public void LlenarTablero()
        {
            for (int i = 1; i<=tablero.Length; i++)
            {
                tablero[i] = i;

            }
            //Asignamos las escaleras.
            tablero[1] = 38;
            tablero[4] = 14;
            tablero[9] = 31;
            tablero[28] = 84;
            tablero[21] = 42;
            tablero[36] = 44;
            tablero[51] = 67;
            tablero[71] = 81;

            // Asignamos las Serpinetes.
            tablero[98] = 78;
            tablero[95] = 75;
            tablero[87] = 24;
            tablero[62] = 19;
            tablero[56] = 52;
            tablero[16] = 6;
            tablero[49] = 11;
            tablero[66] = 60;
        }

      
      

        
    }
}
