using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Escaleras
{
    class Dado
    {
        private static Random ran = new Random();
        
        public int Lanzar()
        {
            return ran.Next(1,7);
        }



    }
}
