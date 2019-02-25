using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    public class Extras
    {
        public List<List<List<string>>> ListarReglas;
        public Program parametro;
        public Extras()
        {
            ListarReglas = new List<List<List<string>>>();
            parametro = new Program();           
        }
        public List<List<string>> Reduccion(List<List<string>> listainit, List<List<string>> listafinal)
        {
            int cont = 0;
            foreach (List<string> elemento in listafinal)
            {
                int cantidadfinal = listafinal.Count();
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
        public static int AsignacionRandimico(ref int a, ref int MaxNoOfRooms, ref int[] Oro , ref int[] Wumpus, ref int[] NumberRoomsPit)
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


            } while (c == a || c == Oro[0] || c == Oro[1] || c == Oro[2] || c == Wumpus[0] || c == NumberRoomsPit[0] || c == NumberRoomsPit[1]);
            return c;
        }

        public static int AsignacionRandimico(ref int MaxNoOfRooms, ref int[] Oro, ref int[] Wumpus, ref int[] NumberRoomsPit)
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
                

            } while (c == Oro[0] || c == Oro[1] || c == Oro[2] || c == Wumpus[0] || c == NumberRoomsPit[0] || c == NumberRoomsPit[1]);
            return c;
        }        

        private void DirectionOfArrows(Location[] CaveSystem, ref int direccion, ref int NoWumpi, ref int[] Wumpus)
        {
            //If there is a wumpus in the room, the game is over, that is the purpose of the first if statement. If the effected room is adjacent to a room with
            //a wumpus then the wumpus is move using the Movewumpus fn in the last for loop. Please refer to this fn for explanation.
            //CaveSystem[a].arrow = true;

            if (CaveSystem[direccion].wumpus == true)
            {
                CaveSystem[direccion].wumpus = false;
                Console.WriteLine("Mataste al mostruo guey");
                NoWumpi--;

                if (NoWumpi == 0)
                {
                    parametro.RemoveWumpus(ref Wumpus);
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


        public void ShootArrows(ref int NroFlechas, Location[] CaveSystem, ref int HunterRoomNumber, ref int NoWumpi, ref int[] BloodRoomsTier1, ref int[] Hedor, ref int[] Wumpus, ref bool Game)
        {
            // This fn starts by decrementing the number of arrows and informing the player if their are none left. Then the player is asked for the direction
            // that the arrows will take. So i ask the player to enter the rooms that arrow should fire or proceed through. I let the player choose l,r or c for left,right
            //and centre respectively.I do this for the first room, then the second rooma nd finally the third room. The input is put into three strings a,b & c.
            //I then have a switch statement with case in turn having a couple of nested if statements. I switch 'a', if it is 'l', then i set d to be the first exit of that
            //room CaveSystem[HunterRoomNumber].exit[0]. I then set string s = 'l' and call the fn DirectionOfArrows. Please refer to this fn now. I then nased on the value of
            //string a determine b, i reassign d == CaveSystem[d].exit[0] to the next room where exit[0] refers to 'l' or left. or exit[1] for c and finally exit[2] for 'r'.            
            NroFlechas = NroFlechas - 1;
            if (NroFlechas == 0)
            {
                Console.WriteLine("Ya no te quedan flechas");
            }
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
    }
}
