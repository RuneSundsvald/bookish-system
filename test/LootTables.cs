using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test
{
    internal class LootTables
    {
        public void SmallShop()
        {
            Bil loot = new Bil();
            int rnum = 0;
            rnum = loot.PlayerLootNumber(7);
            switch (rnum)
            {
                case 1:
                    Console.WriteLine("nothing");
                    break;
                case 2:
                    Console.WriteLine("gas");
                    break;
                case 3:
                    Console.WriteLine("food");
                    break;
                case 4:
                    Console.WriteLine("food");
                    break;
                case 5:
                    Console.WriteLine("comic");
                    break;
                case 6:
                    Console.WriteLine("newspaper");
                    break;
                case 7:
                    Console.WriteLine("wrech");
                    break;
                default:
                    Console.WriteLine("FAIL!!");
                    break;
            }
        }

        public void ShopingCenter() 
        {
            Bil loot = new Bil();
            int rnum = 0;
            rnum = loot.PlayerLootNumber(7);
            switch (rnum)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                default:
                    Console.WriteLine("FAIL!!");
                    break;
            }
        }
        public void GunRange()
        {
            Bil loot = new Bil();
            int rnum = 0;
            rnum = loot.PlayerLootNumber(7);
            switch (rnum)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                default:
                    Console.WriteLine("FAIL!!");
                    break;
            }
        }



    }
}
