using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    public class MundodelAgente
    {
        #region utilitarios
        //bool[,] matriz4Dw = new bool[3,3];
        //bool [,] matriz4Dh = new bool[3, 3];
        //bool [,] matriz4Do = new bool[3, 3];
        #endregion
        //bool[,] matriz4Da = new bool[3, 3];
        bool[] matrizdelAgente;
        Clases.Location[] LocationParameters;
        public Clases.Location[] Matrizllena { get; set; }
        Clases.Extras Metodos;
        int MaxnrodeRooms;
        bool Game = true;
        int indexini = 0;
        int NroWump = 2;
        int NroFlech = 2;
        int a, b, c, d;
        public int AgenteRoomNumber { get; set; }
        public int[] HuecoRoomsNumbers { get; set; }
        public int[] Wumpus { get; set; }
        public int[] Oro { get; set; }
        public string input { get; set; }
        List<List<string>> reglainit;
        public MundodelAgente()
        {
            LocationParameters = new Clases.Location[MaxnrodeRooms];
            Matrizllena = new Clases.Location[MaxnrodeRooms];
            Metodos = new Clases.Extras();
            MaxnrodeRooms = 36;
            Game = true;
            indexini = 0;
            NroWump = 1;
            NroFlech = 1;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            HuecoRoomsNumbers = new int[3];
            Wumpus = new int[1];
            Oro = new int[3];
            input = "";
            reglainit = new List<List<string>>();
        }
        public Location[] Llenado_de_parametros_aledaños(Location[] LocationParameters)
        {
            int valor = AgenteRoomNumber;            
            for (int i = 0; i < 3; i++)
            {                
                for (int q = 0; q < (LocationParameters[HuecoRoomsNumbers[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[HuecoRoomsNumbers[i]].exit[q]].brisa = true;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                Wumpus[i] = Clases.Extras.AsignacionRandimico(valor, this.MaxnrodeRooms, Metodos.Oro, Metodos.Wumpus, Metodos.HuecoRoomsNumbers);
                for (int q = 0; q < (LocationParameters[Wumpus[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[Wumpus[i]].exit[q]].hedor = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Oro[i] = Clases.Extras.AsignacionRandimico(valor, this.MaxnrodeRooms, Metodos.Oro, Metodos.Wumpus, Metodos.HuecoRoomsNumbers);
                for (int q = 0; q < (LocationParameters[Oro[i]].exit.Count); q++)
                {
                    LocationParameters[LocationParameters[Oro[i]].exit[q]].brillo = true;
                }
            }
            return LocationParameters;
        }
        public string Dificiltad()
        {
            Console.WriteLine("Bienvenido a WunpusGame, exiten tres niveles de dificultad: Estan Facil, Medio and Pesadilla;/n En Fasil existen 36 espacios, un Wumpus 'Si no sabes que es Wumpus es un monstruo' y un tesoro; /n Medio son 28 espacios, un Wunpus y un tesoro; /n En pesadilla son 16 espacios, un wumpus y un tesoro; /n Enter & return para medio matener p para pesadilla; default es Facil");
            //I use the console application to output a introduction and receive input from the player. 
            input = Console.ReadLine();
            return input;
        }

        public void MovimientoAgente()
        {
            Console.WriteLine("For the room press u for up, l for left, r for rigth, d for dow.");
            string key = Console.ReadLine();
            int direccion = 0;
            switch (key)
            {
                case "u":
                    direccion = LocationParameters[AgenteRoomNumber].exit[0];
                    break;
                case "l":
                    direccion = LocationParameters[AgenteRoomNumber].exit[1];
                    break;
                case "r":
                    direccion = LocationParameters[AgenteRoomNumber].exit[2];
                    break;
                case "d":
                    direccion = LocationParameters[AgenteRoomNumber].exit[3];
                    break;
                default:
                    Console.WriteLine("No ingreso una direccion valida");
                    break;
            }
            LocationParameters[AgenteRoomNumber].agente = false;
            LocationParameters[direccion].agente = true;
            AgenteRoomNumber = direccion;            
        }
        public void MovimientoAgente(int direccion)
        {
            //The hunter moves to a new room using a direcction of the four adjacent rooms.The first four if statements ascertain whether the room the
            //hunter is now in has a pit, a wumpus or indeed a colony of bats.            
            LocationParameters[AgenteRoomNumber].agente = false;
            LocationParameters[direccion].agente = true;
            AgenteRoomNumber = direccion;
            Metodos.ConprobacionMuerte(direccion);
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
        public void Encontrar_salida()
        {
            input = Dificiltad();
            MaxnrodeRooms = Metodos.Llenado_de_Matriz(input, "f").Length;
            LocationParameters = Metodos.Llenado_de_Matriz(input, "f");
            LocationParameters = Llenado_de_parametros_aledaños(LocationParameters);
            AgenteRoomNumber = Clases.Extras.AsignacionRandimico(MaxnrodeRooms, Oro, Wumpus, HuecoRoomsNumbers);                        
            int anteriorAgente = AgenteRoomNumber;            
            LocationParameters[AgenteRoomNumber].agente = true;            
            while (LocationParameters[AgenteRoomNumber].oro == false)
            {
                //try
                //{
                    Array4DAgente(AgenteRoomNumber);
                    foreach (int elemento in LocationParameters[AgenteRoomNumber].exit)
                    {
                        if (LocationParameters[elemento].hedor == true)
                        {
                            if (NroFlech > 0)
                            {
                                Console.WriteLine(" desea disparar una flecha");
                                string s = Console.ReadLine();
                                if (s == "si")
                                {
                                    Metodos.ShootArrows(Matrizllena, AgenteRoomNumber, ref NroWump, Wumpus, Metodos.Game);
                                    NroFlech = Metodos.NroFlechas;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ya no te quedan flechas");
                            }                            
                        }
                        if (LocationParameters[elemento].hueco == false && LocationParameters[elemento].wumpus == false)
                        {
                            MovimientoAgente(elemento);
                            break;
                        }
                        else
                        {
                            anteriorAgente = AgenteRoomNumber;
                        }
                    }
                    if (anteriorAgente != AgenteRoomNumber)
                    {
                        Console.WriteLine("El sistema no pudo tomar una decicion por favor decida");
                        Opciones();
                        MovimientoAgente();                        
                    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("No se pudo encontrar la salida");
                //    Console.WriteLine(ex);
                //}                
            }
            Console.WriteLine("Encontraste el tesoro felicidades Ganaste");
        }
        public void Array4DAgente(int pos)
        {      
            if (LocationParameters[pos].hedor == true)
            {
                if (NroFlech > 0)
                {
                    Console.WriteLine(" desea disparar una flecha");
                    string s = Console.ReadLine();
                    if (s == "si")
                    {
                        Metodos.ShootArrows(Matrizllena, AgenteRoomNumber, ref NroWump, Wumpus, Metodos.Game);
                        NroFlech = Metodos.NroFlechas;
                    }
                }
                else
                {
                    Console.WriteLine("Ya no te quedan flechas");
                }
                List<List<string>> reglanueva = new List<List<string>>();
                List<string> conjuntos = new List<string>();
                string sentecia = "";
                foreach (int elemento2 in (LocationParameters[pos].exit))
                {
                    if (Metodos.ListarReglas.Count() != 0)
                    {
                        for (int i = 0; i < Metodos.ListarReglas.Count(); i++)
                        {
                            conjuntos = new List<string>();
                            sentecia = "M" + elemento2.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            reglainit = Metodos.ListarReglas[i];
                            reglanueva = Metodos.Reduccion(reglanueva, reglainit);
                        }
                        if (reglanueva == null)
                        {
                            LocationParameters[elemento2].wumpus = true;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                    }
                    else
                    {
                        //reglanueva = Metodos.Reduccion(reglanueva);
                        Console.WriteLine("Puedes sentir hedor");
                        Opciones();
                        MovimientoAgente();
                        pos = AgenteRoomNumber;
                        if (Metodos.ConprobacionCoincidencia(pos))
                        {
                            conjuntos = new List<string>();
                            sentecia = "M" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].wumpus = false;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                        else
                        {
                            conjuntos = new List<string>();
                            sentecia = "M" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].wumpus = true;
                            Metodos.ListarReglas.Add(reglanueva);
                            break;
                        }
                    }                                                                         
                }                
            }
            if (LocationParameters[pos].brillo == true)
            {
                List<List<string>> reglanueva = new List<List<string>>();
                List<string> conjuntos = new List<string>();
                string sentecia = "";
                foreach (int elemento2 in (LocationParameters[pos].exit))
                {
                    if (Metodos.ListarReglas.Count() != 0)
                    {
                        for (int i = 0; i < Metodos.ListarReglas.Count(); i++)
                        {
                            conjuntos = new List<string>();
                            sentecia = "T" + elemento2.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            reglainit = Metodos.ListarReglas[i];
                            reglanueva = Metodos.Reduccion(reglanueva, reglainit);
                        }
                        if (reglanueva == null)
                        {
                            LocationParameters[elemento2].oro = true;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                    }
                    else
                    {
                        //reglanueva = Metodos.Reduccion(reglanueva);
                        //that they can smell the wumpus,hear bats, detect slime or as in the case of blood, the wumpus is two rooms away.
                        Console.WriteLine("Puedes percibir un brillo");
                        Opciones();
                        MovimientoAgente();
                        pos = AgenteRoomNumber;
                        if (Metodos.ConprobacionCoincidencia(pos))
                        {
                            conjuntos = new List<string>();
                            sentecia = "T" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].oro = false;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                        else
                        {
                            conjuntos = new List<string>();
                            sentecia = "T" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].oro = true;
                            Metodos.ListarReglas.Add(reglanueva);
                            break;
                        }
                    }
                }
            }            
            if (LocationParameters[pos].brisa == true)
            {
                List<List<string>> reglanueva = new List<List<string>>();
                List<string> conjuntos = new List<string>();
                string sentecia = "";
                foreach (int elemento2 in (LocationParameters[pos].exit))
                {
                    //List<List<List<string>>> capturador = Metodos.ListarReglas;
                    if (Metodos.ListarReglas.Count() != 0)
                    {
                        for (int i = 0; i < Metodos.ListarReglas.Count(); i++)
                        {
                            conjuntos = new List<string>();
                            sentecia = "A" + elemento2.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            reglainit = Metodos.ListarReglas[i];
                            reglanueva = Metodos.Reduccion(reglanueva, reglainit);
                        }
                        if (reglanueva == null)
                        {
                            LocationParameters[elemento2].hueco = true;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                    }
                    else
                    {
                        //reglanueva = Metodos.Reduccion(reglanueva);
                        Console.WriteLine("Puedes sentir la brisa");
                        Opciones();
                        MovimientoAgente();
                        pos = AgenteRoomNumber;
                        if (Metodos.ConprobacionCoincidencia(pos))
                        {
                            conjuntos = new List<string>();
                            sentecia = "A" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].hueco = false;
                            Metodos.ListarReglas.Add(Metodos.InvertirRegla(reglanueva));
                            break;
                        }
                        else
                        {
                            conjuntos = new List<string>();
                            sentecia = "A" + pos.ToString();
                            conjuntos.Add(sentecia);
                            reglanueva.Add(conjuntos);
                            LocationParameters[pos].hueco = true;
                            Metodos.ListarReglas.Add(reglanueva);
                            break;
                        }
                    }
                }
            }                    
        }      
    }
}
