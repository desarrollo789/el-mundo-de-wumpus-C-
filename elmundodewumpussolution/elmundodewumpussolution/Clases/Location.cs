﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    //This is my class cave which i use for the individual caves or rooms in the maze. I have two constructors because initally because in my initial design some
    //of my rooms had only two rooms that they connected too in some instances. The exit array specifies the room numbers that each room connects to. Their purpose
    //will be shown once i return to main. Finally there is also a list of bolleans associated with each object: pit,slime,blood,wumpus,hunter, bat and arrow which indicates
    // if any these objects are in that cave or in anothe rwords associated with that cave then the boolean is turned to true.
    public class Location
    {
        public List<int> exit = new List<int>();
        public Location()
        {
                    
        }        

        public Location(int a, int b, int c, int d)
        {
            exit.Add(a);
            exit.Add(b);
            exit.Add(c);
            exit.Add(d);
        }
        public Location(int a, int b, int c)
        {
            exit.Add(a);
            exit.Add(b);
            exit.Add(c);

        }
        public Location(int a, int b)
        {
            exit.Add(a);
            exit.Add(b);
        }

        public bool brisa = false;
        public bool hueco = false;
        public bool agente = false;
        public bool wumpus = false;
        public bool hedor = false;
        public bool arrow = false;
        public bool brillo = false;
        public bool oro = false;
    }
}
