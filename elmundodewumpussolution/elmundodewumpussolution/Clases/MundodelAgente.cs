using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    class MundodelAgente
    {
        #region utilitarios
        //bool[,] matriz4Dw = new bool[3,3];
        //bool [,] matriz4Dh = new bool[3, 3];
        //bool [,] matriz4Do = new bool[3, 3];
        #endregion
        bool[,] matriz4Da = new bool[3, 3];
        bool[] matrizdelAgente;
        Clases.Location[] LocationParameters;
        Clases.Extras Metodos;
        int MaxnrodeRooms;
        bool Game = true;
        int indexini = 0; int indexend = 7;
        int NroWump = 2;
        int NroFlech = 2;
        int a, b, c, d;
        public MundodelAgente()
        {
            
        }
    }
}
