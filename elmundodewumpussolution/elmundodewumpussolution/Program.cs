using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution
{
    public class Program
    {        
        public Program()
        {
            
        }
        
        static void Main(string[] args)
        {
            //Aqui es donde inicia el programa
            //Please refer to the Cave class setup after class program. I now setup an array CaveSystem of objects of class Cave. the default id 36 rooms for easy.
            Clases.MundodelAgente AgentWorld;
            Clases.Location[] LocationParameters;
            Clases.Extras Metodos;            
            int MaxnrodeRooms;
            //Definiendo parametros      
            int NroWump = 1;
            int NroFlech = 1;
            //I initially place the hunter in room 6,HunterRoomNumber = 6; the bats in room 7. Please note i set the boolean for each object to true. So for room or cave 6
            //i reference that cave vis CaveSystem ans set the booleanHunter = true. Likewise for the bats. 
            int AgenteRoomNumber;
            //I use an array NumberRoomsPit = new int[2] which the contains the room numbers of the rooms with a pit in the game. BloodRoomsTier1 & 2 are arrays i set up
            //previously but are now reduntant.Wumpus is an array which contains the room numbers of the wumpi, however i only have one wumpus in the game as set out in
            //the spec; so i just use Wumpus[0]; however i set all the code and functions to use the array so i just left it as is.
            int[] HuecoRoomsNumbers;
            int[] Wumpus;
            int[] Oro;


            MaxnrodeRooms = 36;
            LocationParameters = new Clases.Location[MaxnrodeRooms];            
            Metodos = new Clases.Extras();
            AgentWorld = new Clases.MundodelAgente();          
            NroWump = 1;
            NroFlech = 1;
            HuecoRoomsNumbers = new int[3];
            Wumpus = new int[1];
            Oro = new int[3];




            Console.WriteLine("Bienvenido a Wumpus");
            // I red the user input. Depending on the input i declare the which maze i am going to use . The default is easy if the player simply presses return.
            LocationParameters = Metodos.Llenado_de_Matriz(AgentWorld.input,"v");
            AgentWorld.Matrizllena = LocationParameters;
            HuecoRoomsNumbers = Metodos.HuecoRoomsNumbers;
            AgentWorld.HuecoRoomsNumbers = HuecoRoomsNumbers;
            Wumpus = Metodos.Wumpus;
            AgentWorld.Wumpus = Wumpus;
            Oro = Metodos.Oro;
            AgentWorld.Oro = Oro;
            //Pregunta el juegador que desa hacer. Preciona 1 y anter para moverse o 2 y enter para disparar flecha.
            AgentWorld.Encontrar_salida();
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
