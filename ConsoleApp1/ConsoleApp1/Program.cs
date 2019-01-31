using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31jan2019
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class Village
        {
            public static int numberofvillages = 0;
            public Village nextvillage;
            public Village previousvillage;
            public string Villagename;
            public bool isAstrildeHere = false;
            public Village()
            { Village.numberofvillages++; }
        }
        class Countryside
        {
            public Village Maple;

            public Village Toronto;
            public Village Ajax;
            public void MapInitializer()
            {
                Maple = new Village();
                Maple.Villagename = "Maple";
                Maple.previousvillage = null;
                Toronto = new Village();
                Toronto.Villagename = "Toronto";
                Toronto.previousvillage = null;
                Ajax = new Village();
                Ajax.Villagename = "Ajax";
                Ajax.nextvillage = null;
                Ajax.previousvillage = Toronto;
                Ajax.isAstrildeHere = true;


            }
        }
    }
}
