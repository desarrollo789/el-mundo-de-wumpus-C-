using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution
{
    public class Program
    {
        //Please refer to the Cave class setup after class program. I now setup an array CaveSystem of objects of class Cave. the default id 36 rooms for easy.
        Clases.Location[] LocationParameters;
        int MaxnrodeRooms;
        //Aqui es donde inicia el prgrama
        //Definiendo parametros
        bool Game = true;
        int indexini = 0; int indexend = 7;
        int NroWump = 2;
        int NroFlech = 2;
        int a, b, c, d;
        //I initially place the hunter in room 6,HunterRoomNumber = 6; the bats in room 7. Please note i set the boolean for each object to true. So for room or cave 6
        //i reference that cave vis CaveSystem ans set the booleanHunter = true. Likewise for the bats. 
        int AgenteRoomNumber;        
        int MucielagosRoomNumeber;        
        //I use an array NumberRoomsPit = new int[2] which the contains the room numbers of the rooms with a pit in the game. BloodRoomsTier1 & 2 are arrays i set up
        //previously but are now reduntant.Wumpus is an array which contains the room numbers of the wumpi, however i only have one wumpus in the game as set out in
        //the spec; so i just use Wumpus[0]; however i set all the code and functions to use the array so i just left it as is.
        int[] HuecoRoomsNumbers;
        int[] BloodRoomsTier1 ;
        int[] BloodRoomsTier2 ;
        int[] Wumpus;
        int[] Oro;

        //Esta varieble se refiere a la temperatura para los murcielagos
        int TemperaturaLocation = 4;
        public Program()
        {
            LocationParameters = new Clases.Location[MaxnrodeRooms];
            MaxnrodeRooms = 36;
            Game = true;
            indexini = 0; indexend = 7;
            NroWump = 1;
            NroFlech = 1;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            HuecoRoomsNumbers = new int[3];
            BloodRoomsTier1 = new int[3];
            BloodRoomsTier2 = new int[3];
            Wumpus = new int[1];
            Oro = new int[3];
        }
        public void RemoveWumpus(ref int[] Wumpus)
        {
            //Since  i am going to move the wumpus, i first turn the blood boolean to false in all the effected objects. I do this in the first for loop
            //Then i move the wumpus to a adjacent room using the next for loop. Then when the wumpus has moved i set the blood boolean to true for the relevant rooms.           

            for (int i = 0; i < 1; i++)
            {
                Wumpus[0] = Clases.Extras.AsignacionRandimico(ref AgenteRoomNumber, ref MaxnrodeRooms, ref MucielagosRoomNumeber, ref Wumpus, ref HuecoRoomsNumbers);
                //CaveSystem[Wumpus[i]].wumpus = true;
                LocationParameters[Wumpus[i]].wumpus = false;
                for (int q = 0; q < (LocationParameters[Wumpus[i]].exit.Length); q++)
                {
                    LocationParameters[LocationParameters[Wumpus[i]].exit[q]].hedor = false;
                }
            }            
        }
        private void Main(string[] args)
        {                        
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
            //Cave[] CaveSystem = new Cave[NoOfRooms];
            LocationParameters[0] = new Clases.Location(a = 1, b = 6);
            LocationParameters[1] = new Clases.Location(a = 0, b = 2, c = 7);
            LocationParameters[2] = new Clases.Location(a = 1, b = 3, c = 8);
            LocationParameters[3] = new Clases.Location(a = 2, b = 4, c = 9);
            LocationParameters[4] = new Clases.Location(a = 3, b = 5, c = 10);
            LocationParameters[5] = new Clases.Location(a = 4, b = 11);
            LocationParameters[6] = new Clases.Location(a = 0, b = 7, c = 12);
            LocationParameters[7] = new Clases.Location(a = 1, b = 6, c = 8, d = 13);
            LocationParameters[8] = new Clases.Location(a = 2, b = 7, c = 9, d = 14);
            LocationParameters[9] = new Clases.Location(a = 3, b = 8, c = 10, d = 15);
            LocationParameters[10] = new Clases.Location(a = 4, b = 9, c = 11, d = 16);
            LocationParameters[11] = new Clases.Location(a = 5, b = 10, c = 17);
            LocationParameters[12] = new Clases.Location(a = 6, b = 13, c = 18);
            LocationParameters[13] = new Clases.Location(a = 7, b = 12, c = 14, d = 19);
            LocationParameters[14] = new Clases.Location(a = 8, b = 13, c = 15, d = 20);
            LocationParameters[15] = new Clases.Location(a = 9, b = 14, c = 16, d = 21);
            LocationParameters[16] = new Clases.Location(a = 10, b = 15, c = 17, d = 22);
            LocationParameters[17] = new Clases.Location(a = 11, b = 16, c = 23);
            LocationParameters[18] = new Clases.Location(a = 12, b = 19, c = 24);
            LocationParameters[19] = new Clases.Location(a = 13, b = 18, c = 20, d = 25);
            LocationParameters[20] = new Clases.Location(a = 14, b = 19, c = 21, d = 26);
            LocationParameters[21] = new Clases.Location(a = 15, b = 20, c = 22, d = 27);
            LocationParameters[22] = new Clases.Location(a = 16, b = 21, c = 23, d = 28);
            LocationParameters[23] = new Clases.Location(a = 17, b = 22, c = 29);
            LocationParameters[24] = new Clases.Location(a = 18, b = 15, c = 30);
            LocationParameters[25] = new Clases.Location(a = 19, b = 24, c = 26, d = 31);
            LocationParameters[26] = new Clases.Location(a = 20, b = 25, c = 27, d = 32);
            LocationParameters[27] = new Clases.Location(a = 21, b = 26, c = 28, d = 33);
            LocationParameters[28] = new Clases.Location(a = 22, b = 27, c = 29, d = 34);
            LocationParameters[29] = new Clases.Location(a = 23, b = 28, c = 35);
            LocationParameters[30] = new Clases.Location(a = 24, b = 31);
            LocationParameters[31] = new Clases.Location(a = 25, b = 30, c = 32);
            LocationParameters[32] = new Clases.Location(a = 26, b = 31, c = 33);
            LocationParameters[33] = new Clases.Location(a = 27, b = 32, c = 34);
            LocationParameters[34] = new Clases.Location(a = 28, b = 33, c = 35);
            LocationParameters[35] = new Clases.Location(a = 29, b = 34);

            
            //I now put the wumpus into a room. I use a function called SetUpIndex. Please refer to this fn for explanation.I then set the boolean for the wumpus for that cave
            //to true.
            //Wumpus[0] = SetUpIndex(ref HunterRoomNumber, ref MaxNoOfRooms,ref RoomNumberBats,ref Wumpus, ref NumberRoomsPit);
            //CaveSystem[Wumpus[0]].wumpus = true;
            //This for loop will setup the rooms with pits and set the corresponding boolean for the relevant object. Also i have another for loop inside which sets 
            //the slime boolean for each relevant object. I do this by referencing the the exit property of each object and then referencing the slime boolean for the
            //corresponding room. Firstly i attain the rooms adjacent to the pits: CaveSystem[NumberRoomsPit[0]].exit[q] and i change their boolean slime:
            //CaveSystem[CaveSystem[NumberRoomsPit[0]].exit[q]].slime = true;
            for (int i = 0; i < 3; i++)
            {
                HuecoRoomsNumbers[i] = Clases.Extras.AsignacionRandimico(ref indexini, ref MaxnrodeRooms, ref MucielagosRoomNumeber, ref Wumpus, ref HuecoRoomsNumbers);
                //NumberRoomsPit[0] = CaveSystem[HunterRoomNumber].exit[0];
                LocationParameters[HuecoRoomsNumbers[i]].hueco = true;
                for (int q = 0; q < (LocationParameters[HuecoRoomsNumbers[i]].exit.Length); q++)
                {
                    LocationParameters[LocationParameters[HuecoRoomsNumbers[i]].exit[q]].brisa = true;                    
                }
            }
            for (int i = 0; i < 1; i++)
            {
                Wumpus[0] = Clases.Extras.AsignacionRandimico(ref AgenteRoomNumber, ref MaxnrodeRooms, ref MucielagosRoomNumeber, ref Wumpus, ref HuecoRoomsNumbers);
                //CaveSystem[Wumpus[i]].wumpus = true;
                LocationParameters[Wumpus[i]].wumpus = true;
                for (int q = 0; q < (LocationParameters[Wumpus[i]].exit.Length); q++)
                {
                    LocationParameters[LocationParameters[Wumpus[i]].exit[q]].hedor = true;
                }
            }
            for (int i = 0; i > 3; i++)
            {
                Oro[i] = Clases.Extras.AsignacionRandimico(ref indexini, ref MaxnrodeRooms, ref MucielagosRoomNumeber, ref Wumpus, ref HuecoRoomsNumbers);
                LocationParameters[Oro[i]].brillo = true;
                for (int q = 0; q < (LocationParameters[Oro[i]].exit.Length); q++)
                {
                    LocationParameters[LocationParameters[Oro[i]].exit[q]].brillo = true;
                }
            }
            //This while loop runs for the duration of the game. When Game is set to false, the game terminates.
            //that they can smell the wumpus,hear bats, detect slime or as in the case of blood, the wumpus is two rooms away.
            if (LocationParameters[AgenteRoomNumber].brisa == true)
            {
                Console.WriteLine("Puedes sentir el viento");
            }
            if (LocationParameters[AgenteRoomNumber].hedor == true)
            {
                Console.WriteLine("Puedes percibir un hedor");
            }
            if (LocationParameters[AgenteRoomNumber].brillo == true)
            {
                Console.WriteLine("Puedes notar un brillo");
            }
            Console.WriteLine("Existen salidas:");

            if (LocationParameters[AgenteRoomNumber].exit[0] < 0)
            {
                Console.Write("Arriba,");
            }
            if (LocationParameters[AgenteRoomNumber].exit[1] < 0)
            {
                Console.WriteLine("Izquierda,");
            }
            if (LocationParameters[AgenteRoomNumber].exit[2] < 0)
            {
                Console.WriteLine("Derecha,");
            }
            if (LocationParameters[AgenteRoomNumber].exit[3] < 0)
            {
                Console.WriteLine("Abajo");
            }
            //Pregunta el juegador que desa hacer. Preciona 1 y anter para moverse o 2 y enter para disparar flecha.
            Console.WriteLine("Que te gustaria hacer?");
            Console.WriteLine("Preciona 1 y return para moverte");
            if (NroFlech > 0)
            {
                Console.WriteLine(" o precona 2 y return para disparar");
            }
            string s = Console.ReadLine();
            if (s == "1")
            {
                //The hunter moves to a new room using a random selection of the three adjacent rooms.The first three if statements ascertain whether the room the
                //hunter is now in has a pit, a wumpus or indeed a colony of bats.
                AgenteRoomNumber = Clases.Extras.AsignacionRandimico(ref MaxnrodeRooms, ref MucielagosRoomNumeber, ref Wumpus, ref HuecoRoomsNumbers);
                LocationParameters[AgenteRoomNumber].agente = true;
                if (LocationParameters[AgenteRoomNumber].hueco == true)
                {
                    Console.WriteLine("You have encountered a pit and a Wumpus, you are dead, Game Over");
                    Game = false;
                }
                if (LocationParameters[AgenteRoomNumber].wumpus == true)
                {
                    Console.WriteLine("You have encountered a Wumpus, you are dead, Game Over");
                    Game = false;
                }
                else if (s == "2" && NoArrows > 0)
                {
                    //If the Player chooses to allow the hunter to fire an arrow they execution follows the said fn. Please refer to this fn for clarification
                    ShootArrows(ref NoArrows, CaveSystem, ref HunterRoomNumber, ref NoWumpi, ref BloodRoomsTier1, ref BloodRoomsTier2, ref Wumpus, ref Game);
                }
            }            
        }
    }
}
