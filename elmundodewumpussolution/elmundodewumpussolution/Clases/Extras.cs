using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    public class Extras
    {
        //Please refer to the Cave class setup after class program. I now setup an array CaveSystem of objects of class Cave. the default id 36 rooms for easy.
        Location[] LocationParameters;
        int MaxnrodeRooms;
        public List<List<List<string>>> ListarReglas { get; set; }
        public Program parametro;
        //Definiendo parametros
        public bool Game { get; set; }
        int a, b, c, d;
        public int NroFlechas { get; set; }
        //I initially place the hunter in room 6,HunterRoomNumber = 6; the bats in room 7. Please note i set the boolean for each object to true. So for room or cave 6
        //i reference that cave vis CaveSystem ans set the booleanHunter = true. Likewise for the bats. 
        int AgenteRoomNumber;
        //I use an array NumberRoomsPit = new int[2] which the contains the room numbers of the rooms with a pit in the game. BloodRoomsTier1 & 2 are arrays i set up
        //previously but are now reduntant.Wumpus is an array which contains the room numbers of the wumpi, however i only have one wumpus in the game as set out in
        //the spec; so i just use Wumpus[0]; however i set all the code and functions to use the array so i just left it as is.        
        public int[] HuecoRoomsNumbers { get; set; }
        public int[] Wumpus { get; set; }
        public int[] Oro { get; set; }
        public Extras()
        {
            ListarReglas = new List<List<List<string>>>();
            parametro = new Program();           
            MaxnrodeRooms = 36;
            LocationParameters = new Location[MaxnrodeRooms];
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            HuecoRoomsNumbers = new int[3];
            Wumpus = new int[1];
            Oro = new int[3];
            Game = true;
        }
                       
        public Location[] Llenado_de_Matriz(string input, string accioma)
        {                        
            if (input == "p")
            {
                MaxnrodeRooms = 15;
                LocationParameters = new Location[MaxnrodeRooms];
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
                //permite el llenado de las casillas aledañas
                if (accioma == "v")
                {
                    LocationParameters = Llenado_de_parametros_aledaños(LocationParameters);
                }                
                return LocationParameters;
            }

            else if (input == "i")
            {
                MaxnrodeRooms = 27;
                LocationParameters = new Location[MaxnrodeRooms];
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
                //permite el llenado de las casillas aledañas
                if (accioma == "v")
                {
                    LocationParameters = Llenado_de_parametros_aledaños(LocationParameters);
                }                
                return LocationParameters;
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
            //permite el llenado de las casillas aledañas
            if (accioma == "v")
            {                
                LocationParameters = Llenado_de_parametros_aledaños(LocationParameters);
            }
            return LocationParameters;
        }

        public Location[] Llenado_de_parametros_aledaños(Location [] LocationParameters)
        {
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
                HuecoRoomsNumbers[i] = Clases.Extras.AsignacionRandimico(this.AgenteRoomNumber, this.MaxnrodeRooms, this.Oro, this.Wumpus, this.HuecoRoomsNumbers);
                //NumberRoomsPit[0] = CaveSystem[HunterRoomNumber].exit[0];
                LocationParameters[HuecoRoomsNumbers[i]].hueco = true;
                for (int q = 0; q < (LocationParameters[HuecoRoomsNumbers[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[HuecoRoomsNumbers[i]].exit[q]].brisa = true;
                }
            }            
            for (int i = 0; i < 1; i++)
            {
                Wumpus[i] = Clases.Extras.AsignacionRandimico(this.AgenteRoomNumber, this.MaxnrodeRooms, this.Oro, this.Wumpus, this.HuecoRoomsNumbers);
                //CaveSystem[Wumpus[i]].wumpus = true;
                LocationParameters[Wumpus[i]].wumpus = true;
                for (int q = 0; q < (LocationParameters[Wumpus[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[Wumpus[i]].exit[q]].hedor = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Oro[i] = Clases.Extras.AsignacionRandimico(this.AgenteRoomNumber, this.MaxnrodeRooms, this.Oro, this.Wumpus, this.HuecoRoomsNumbers);
                LocationParameters[Oro[i]].oro = true;
                for (int q = 0; q < (LocationParameters[Oro[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[Oro[i]].exit[q]].brillo = true;
                }
            }
            return LocationParameters;
        }

        public void Base_de_Conocimiento(List<List<string>> lista)
        {
            ListarReglas.Add(lista);
        }

        public List<List<string>> InvertirRegla(List<List<string>> lista)
        {
            List<List<string>> lista2 = new List<List<string>>();
            List<string> elemento2 = new List<string>();
            foreach (List<string> elemento in lista)
            {
                foreach (string e in elemento)
                {                    
                    elemento2.Add("-" + e);
                }
                lista2.Add(elemento2);
            }
            return lista2;
        }
        public List<List<string>> Reduccion(List<List<string>> listainit)
        {
            return listainit;
        }
        public List<List<string>> Reduccion(List<List<string>> listafinal, List<List<string>> listainit)
        {
            int cont = 0;
            foreach (List<string> elemento in listafinal)
            {                
                if (listainit.Contains(elemento))
                {
                    cont++;
                }
                if (cont == listafinal.Count())
                {
                    return null;
                }                
            }
            
            foreach (List<string> e1 in listainit)
            {
                foreach (string e2 in e1)
                {
                    string elementoant = e2;
                    foreach (List<string> elemento1 in listainit)
                    {
                        foreach (string elemento2 in elemento1)
                        {
                            string negacionE = "-" + elementoant;
                            if (elemento1.Contains(negacionE) && elemento1.Contains(elementoant))
                            {
                                ListarReglas.Remove(listainit);                    
                                return listafinal;
                            }
                        }
                    }
                }
            }            

            foreach (List<string> e1 in listafinal)
            {
                foreach (string e2 in e1)
                {
                    string negacionE = "-" + e2;
                    foreach (List<string> elemento1 in listainit)
                    {
                        foreach (string elemento2 in elemento1)
                        {                            
                            if (elemento1.Contains(negacionE))
                            {
                                elemento1.Remove(negacionE);
                                e1.Remove(e2);
                                foreach (string valor in e1)
                                {
                                    elemento1.Add(valor);
                                }
                            }
                        }                        
                    }
                }                    
            }
            return listainit;                                    
        }
        public static int AsignacionRandimico(int a, int MaxNoOfRooms, int[] Oro , int[] Wumpus, int[] NumberRoomsPit)
        {
            //Este metodo reduce la funcion                                          
            //This fn will return a room number using a random generator provided it does not equal any the argruments it is compared against. By way of reference it will
            //be passed the max number of rooms, the room numbers that contain the bats,wumpi and pits. "a" usually is usually the room of the hunter. "c" will return
            //a value within the range of the number of caves. I do this in a do while loop which keeps going if  c generated is the same as 'a' or either room with Bats , wumpi
            //or pits. There are two versions of this function. This version takes five argruments and compares all in the while statement. Howver i als have a version
            //which only takes three argruments which is used in the BatEncounter fn.
            int c = 0;
            do
            {
                Random random = new Random();
                c = random.Next(0, MaxNoOfRooms);


            } while (c == a || c == Oro[0] || c == Oro[1] || c == Oro[2] || c == Wumpus[0] || c == NumberRoomsPit[0] || c == NumberRoomsPit[1] || c == NumberRoomsPit[2]);
            return c;
        }

        public static int AsignacionRandimico(int MaxNoOfRooms, int[] Oro, int[] Wumpus, int[] NumberRoomsPit)
        {
            //Este metodo reduce la funcion                                          
            //This fn will return a room number using a random generator provided it does not equal any the argruments it is compared against. By way of reference it will
            //be passed the max number of rooms, the room numbers that contain the bats,wumpi and pits. "a" usually is usually the room of the hunter. "c" will return
            //a value within the range of the number of caves. I do this in a do while loop which keeps going if  c generated is the same as 'a' or either room with Bats , wumpi
            //or pits. There are two versions of this function. This version takes five argruments and compares all in the while statement. Howver i als have a version
            //which only takes three argruments which is used in the BatEncounter fn.
            int c = 0;
            do
            {
                Random random = new Random();
                c = random.Next(0, MaxNoOfRooms);
                

            } while (c == Oro[0] || c == Oro[1] || c == Oro[2] || c == Wumpus[0] || c == NumberRoomsPit[0] || c == NumberRoomsPit[1] || c == NumberRoomsPit[1]);
            return c;
        }

        public void RemoveWumpus(ref int[] Wumpus)
        {
            //Since  i am going to move the wumpus, i first turn the blood boolean to false in all the effected objects. I do this in the first for loop
            //Then i move the wumpus to a adjacent room using the next for loop. Then when the wumpus has moved i set the blood boolean to true for the relevant rooms.           

            for (int i = 0; i < 1; i++)
            {
                //Wumpus[0] = Clases.Extras.AsignacionRandimico(ref AgenteRoomNumber, ref MaxnrodeRooms, ref Oro, ref Wumpus, ref HuecoRoomsNumbers);
                //CaveSystem[Wumpus[i]].wumpus = true;
                LocationParameters[Wumpus[i]].wumpus = false;
                for (int q = 0; q < (LocationParameters[Wumpus[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[Wumpus[i]].exit[q]].hedor = false;
                }
            }
        }

        private void DirectionOfArrows(Location[] CaveSystem, ref int direccion, ref int NoWumpi, ref int[] Wumpus)
        {
            //If there is a wumpus in the room, the game is over, that is the purpose of the first if statement. If the effected room is adjacent to a room with
            //a wumpus then the wumpus is move using the Movewumpus fn in the last for loop. Please refer to this fn for explanation.
            //CaveSystem[a].arrow = true;

            if (CaveSystem[direccion].wumpus == true)
            {
                CaveSystem[direccion].wumpus = false;
                Console.WriteLine("Mataste al mostruo");
                NoWumpi--;

                if (NoWumpi == 0)
                {
                    RemoveWumpus(ref Wumpus);
                    Console.WriteLine("Felicidades todos los wumpus han muerto");                  
                }
            }
            //for (int z = 0; z < 4; z++)
            //{
            //    if (direccion == CaveSystem[Wumpus[0]].exit[z])
            //    {
            //        parametro.RemoveWumpus(ref Wumpus);
            //    }
            //}
        }

        public void Opciones()
        {
            Console.WriteLine("Existen salidas:");

            if (LocationParameters[AgenteRoomNumber].exit.Count == 1)
            {
                Console.Write("Arriba,");
            }
            if (LocationParameters[AgenteRoomNumber].exit.Count == 2)
            {
                Console.WriteLine("Arriba, Izquierda,");
            }
            if (LocationParameters[AgenteRoomNumber].exit.Count == 3)
            {
                Console.WriteLine("Arriba, Izquierda, Derecha,");
            }
            if (LocationParameters[AgenteRoomNumber].exit.Count == 4)
            {
                Console.WriteLine("Arriba, Izquierda, Derecha, Abajo");
            }
        }

        public void ShootArrows(Location[] CaveSystem, int HunterRoomNumber, ref int NoWumpi, int[] Wumpus, bool Game)
        {
            // This fn starts by decrementing the number of arrows and informing the player if their are none left. Then the player is asked for the direction
            // that the arrows will take. So i ask the player to enter the rooms that arrow should fire or proceed through. I let the player choose l,r or c for left,right
            //and centre respectively.I do this for the first room, then the second rooma nd finally the third room. The input is put into three strings a,b & c.
            //I then have a switch statement with case in turn having a couple of nested if statements. I switch 'a', if it is 'l', then i set d to be the first exit of that
            //room CaveSystem[HunterRoomNumber].exit[0]. I then set string s = 'l' and call the fn DirectionOfArrows. Please refer to this fn now. I then nased on the value of
            //string a determine b, i reassign d == CaveSystem[d].exit[0] to the next room where exit[0] refers to 'l' or left. or exit[1] for c and finally exit[2] for 'r'.                                    
            NroFlechas = NroFlechas - 1;
            Opciones();
            Console.WriteLine("Please chose which room to fire your Arrow");
            Console.WriteLine("For the room press u for up, l for left, r for rigth, d for dow.");
            string key = Console.ReadLine();
            int direccion = 0;                      
            switch (key)
            {
                case "u":
                    direccion = CaveSystem[HunterRoomNumber].exit[0];               
                    DirectionOfArrows(CaveSystem,ref direccion, ref NoWumpi, ref Wumpus);
                    break;
                case "l":
                    direccion = CaveSystem[HunterRoomNumber].exit[1];
                    DirectionOfArrows(CaveSystem, ref direccion, ref NoWumpi, ref Wumpus);
                    break;
                case "r":
                    direccion = CaveSystem[HunterRoomNumber].exit[2];
                    DirectionOfArrows(CaveSystem, ref direccion, ref NoWumpi, ref Wumpus);
                    break;
                case "d":
                    direccion = CaveSystem[HunterRoomNumber].exit[3];
                    DirectionOfArrows(CaveSystem, ref direccion, ref NoWumpi, ref Wumpus);
                    break;                
                default:
                    break;
            }

        }
        public bool ConprobacionCoincidencia(int pos)
        {
            //The hunter moves to a new room using a random selection of the three adjacent rooms.The first three if statements ascertain whether the room the
            //hunter is now in has a pit, a wumpus or indeed a colony of bats.            
            if (LocationParameters[pos].hueco == true)
            {                
                return false;
            }
            if (LocationParameters[pos].wumpus == true)
            {                
                return false;
            }
            if (LocationParameters[pos].oro == true)
            {               
                return false;
            }
            return true;
        }

        public bool ConprobacionMuerte(int pos)
        {
            //This while loop runs for the duration of the game. When Game is set to false, the game terminates.
            //The hunter moves to a new room using a random selection of the three adjacent rooms.The first three if statements ascertain whether the room the
            //hunter is now in has a pit, a wumpus or indeed a colony of bats.            
            if (LocationParameters[pos].hueco == true)
            {
                Console.WriteLine("You have encountered a pit and a Wumpus, you are dead, Game Over");
                return Game = false;
            }
            if (LocationParameters[pos].wumpus == true)
            {
                Console.WriteLine("You have encountered a Wumpus, you are dead, Game Over");
                return Game = false;
            }
            return Game = true;
        }
    }
}
