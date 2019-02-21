using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui es donde inicia el prgrama
            //Definiendo parametros
            bool Game = true;
            int indexini; int indexend = 7;
            int NroWump = 2;
            int NroFlech = 2;
            int a = 0, b = 0, c = 0, d = 0;
            int MaxnrodeRooms = 36;
            //Please refer to the Cave class setup after class program. I now setup an array CaveSystem of objects of class Cave. the default id 36 rooms for easy.
            Clases.Location[] LocationParameters = new Clases.Location[MaxnrodeRooms];
            //Esta varieble se refiere a la temperatura para los murcielagos
            int TemperaturaLocation = 4;

            Console.WriteLine("Bienvenido a WunpusGame, exiten tres niveles de dificultad: Estan Facil, Medio and Pesadilla;/n En Fasil existen 36 espacios, un Wumpus 'Si no sabes que es Wumpus es un monstruo' y una colonia de murcielagos; /n Medio son 28 espacios, un Wunpus y una colinia de murcielagos; /n En pesadilla son 16 espacios, un wumpus y una colonia de murcielagos; /n Los murcielagos son mas agrecivos a medida que se aumenta el nivel; /n Enter & return para medio matener p para pesadilla; default es Facil");
            //I use the console application to output a introduction and receive input from the player. 
            string input = Console.ReadLine();
            // I red the user input. Depending on the input i declare the which maze i am going to use . The default is easy if the player simply presses return.
            if (input == "p")
            {
                TemperaturaLocation = 2;
                MaxnrodeRooms = 15;
                LocationParameters[0] = new Clases.Location(a = 1, b = 4);
                LocationParameters[1] = new Clases.Location(a = 0, b = 2, c = 5);
                LocationParameters[2] = new Clases.Location(a = 1, b = 3, c = 6);
                LocationParameters[3] = new Clases.Location(a = 2, b = 7);
                LocationParameters[4] = new Clases.Location(a = 0, b = 5, c = 8);
                LocationParameters[5] = new Clases.Location(a = 1, b = 4, c = 6, d = 9);
                LocationParameters[6] = new Clases.Location(a = 2, b = 5, c = 7, d = 10);
                LocationParameters[7] = new Clases.Location(a = 3, b = 6, c = 11);
                LocationParameters[8] = new Clases.Location(a = 4, b = 9, c = 12);
                LocationParameters[9] = new Clases.Location(a = 5, b = 8, c = 10, d = 13);
                LocationParameters[10] = new Clases.Location(a = 6, b = 9, c = 11, d = 14);
                LocationParameters[11] = new Clases.Location(a = 7, b = 10, c = 15);
                LocationParameters[12] = new Clases.Location(a = 8, b = 13);
                LocationParameters[13] = new Clases.Location(a = 9, b = 12, c = 14);
                LocationParameters[14] = new Clases.Location(a = 10, b = 13, c = 15);
                LocationParameters[15] = new Clases.Location(a = 11, b = 14);
            }

            else if (input == "o")
            {
                MaxnrodeRooms = 27;
                TemperaturaLocation = 3;
                //Cave[] CaveSystem = new Cave[NoOfRooms];
                LocationParameters[0] = new Clases.Location(a = 1, b = 5);
                LocationParameters[1] = new Clases.Location(a = 0, b = 2, c = 6);
                LocationParameters[2] = new Clases.Location(a = 1, b = 3, c = 7);
                LocationParameters[3] = new Clases.Location(a = 2, b = 4, c = 8);
                LocationParameters[4] = new Clases.Location(a = 3, b = 9);
                LocationParameters[5] = new Clases.Location(a = 0, b = 6, c = 10);
                LocationParameters[6] = new Clases.Location(a = 1, b = 5, c = 7, d = 11);
                LocationParameters[7] = new Clases.Location(a = 2, b = 6, c = 8, d = 12);
                LocationParameters[8] = new Clases.Location(a = 3, b = 7, c = 9, d = 13);
                LocationParameters[9] = new Clases.Location(a = 4, b = 8, c = 14);
                LocationParameters[10] = new Clases.Location(a = 5, b = 11, c = 15);
                LocationParameters[11] = new Clases.Location(a = 6, b = 10, c = 12, d = 16);
                LocationParameters[12] = new Clases.Location(a = 7, b = 11, c = 13, d = 17);
                LocationParameters[13] = new Clases.Location(a = 8, b = 12, c = 14, d = 18);
                LocationParameters[14] = new Clases.Location(a = 9, b = 13, c = 19);
                LocationParameters[15] = new Clases.Location(a = 10, b = 16, c = 20);
                LocationParameters[16] = new Clases.Location(a = 11, b = 15, c = 17, d = 21);
                LocationParameters[17] = new Clases.Location(a = 12, b = 16, c = 18, d = 22);
                LocationParameters[18] = new Clases.Location(a = 13, b = 17, c = 19, d = 23);
                LocationParameters[19] = new Clases.Location(a = 14, b = 18, c = 24);
                LocationParameters[20] = new Clases.Location(a = 15, b = 21);
                LocationParameters[21] = new Clases.Location(a = 16, b = 20, c = 22);
                LocationParameters[22] = new Clases.Location(a = 17, b = 21, c = 23);
                LocationParameters[23] = new Clases.Location(a = 18, b = 22, c = 24);
                LocationParameters[24] = new Clases.Location(a = 19, b = 23);                
            }
        }
    }
}
