using System;
using System.Collections.Generic;

namespace OOPLections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Palladin> listPalladins = new List<Palladin>();
            listPalladins.Add(new Palladin("123456Artos", 1000000000));
            listPalladins.Add(new Palladin("Uther"));
            ShowPalladinCollection(listPalladins);
            for (int i = 0; i < 5; i++)
            {
                listPalladins[0].LevelUP();
            }
            for (int i = 0; i < 20; i++)
            {
                listPalladins[1].LevelUP();
            }
            ShowPalladinCollection(listPalladins);
            Console.ReadKey();
        }
        private static void ShowPalladinCollection(List<Palladin>  listPalladins)
        {
            foreach (Palladin item in listPalladins)
            {
                item.Show();
            }
        }
    }
}
