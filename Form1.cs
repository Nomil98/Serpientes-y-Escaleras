using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_Escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tablero tab1 = new Tablero();
        Jugador j1 = new Jugador(1);
        Jugador j2 = new Jugador(2);
        Dado d1 = new Dado();
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            while (j1.Posicion < 100 && j2.Posicion < 100)
            {
                j1.avance(d1.Lanzar());
                j2.avance(d1.Lanzar());

                TxJuego.Text = j1.ToString() + Environment.NewLine + j2.ToString() + Environment.NewLine;
            }
            if (j1.Posicion == 100 && j2.Posicion == 100)
            {
                TxJuego.Text = "Es un empate";
            }

           else  if (j1.Posicion >= 100)
           
                TxJuego.Text = "El jugador número uno es el ganador";
            else
                TxJuego.Text = "El jugador número dos es el ganador";
            
           
                
            

        }
    }
}
