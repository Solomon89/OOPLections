using OOPLections.Models;
using System;
using System.Collections.Generic;

namespace OOPLections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> listCharacter = new List<Character>();
            listCharacter.Add(new Palladin("123456Artos", 1000000000));
            listCharacter.Add(new Priest("Uther"));
            listCharacter.Add(new Priest("Uther2"));
            listCharacter.Add(new Priest("Uther3"));
            ShowPalladinCollection(listCharacter);
            for (int i = 0; i < 5; i++)
            {
                listCharacter[0].LevelUP();
            }
            for (int i = 0; i < 20; i++)
            {
                listCharacter[1].LevelUP();
              
            }
            ShowPalladinCollection(listCharacter);
            Console.ReadKey();
        }
        private static void ShowPalladinCollection(List<Character> listCharacter)
        {
            foreach (var item in listCharacter)
            {
                bool isPaladin = (item is Palladin);
                item.Show(!isPaladin);
                if (isPaladin)
                {
                    Console.WriteLine($" Power = {((Palladin)item).Power}");
                }
                

            }
        }
    }
    enum Characters
    {
        Palladin,
        Warrior,
        Priest
    }
}
