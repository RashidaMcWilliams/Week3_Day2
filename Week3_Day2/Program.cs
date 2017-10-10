using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boaty = new Boat(3, "Boaty", 18.6);
            boaty.Move();
            boaty.BoatInfo();

            Boat boat2 = new Boat(14, "Boat 2", 30.8);
            boat2.BoatInfo();

        }
    }
}
