using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmundodewumpussolution.Clases
{
    class Extras
    {
        public static int AsignacionRandimico(ref int a, ref int MaxNoOfRooms, ref int RoomNumberBats, ref int[] Wumpus, ref int[] NumberRoomsPit)
        {
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


            } while (c == a || c == RoomNumberBats || c == Wumpus[0] || c == NumberRoomsPit[0] || c == NumberRoomsPit[1] || c == Wumpus[1]);
            return c;
        }
    }
}
