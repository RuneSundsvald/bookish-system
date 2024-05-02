using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace test
{
    internal class PlaceMenu
    {
        Bil player = new Bil();
        LootTables Loot = new LootTables();
        int place = 1;
        bool exit = false;

        //all that happens at the small shop
        public void smallshop()
        {
            Console.WriteLine("you drive to the Small shop you found");

            Loot.SmallShop();
            Console.WriteLine("click to keep going");
            Console.ReadKey();

        }

        //The menu for picking where to go
        public void Menu(int x)
        {
            switch (x)
            {
                //main menu
                case 0:
                    
                    Console.WriteLine("1. Small Shop 25,7km Away");
                    Console.WriteLine("2. Shoping center 63,2km Away");
                    Console.WriteLine("3. Shoting range 28,7km Away");
                    Console.WriteLine("4. Gas station 180km Away");
                    Console.Write("Enter your choice: ");
                    break;

                //smallshop menu
                case 1:
                    
                    Console.WriteLine("1. Small Shop you are here");
                    Console.WriteLine("2. Shoping center 56,2km Away");
                    Console.WriteLine("3. Shoting range 23,6km Away");
                    Console.WriteLine("4. Gas station 202km Away");
                    Console.Write("Enter your choice: ");
                    break;

                //shopingcenter menu
                case 2:
                    
                    Console.WriteLine("1. Small Shop 56,2km Away");
                    Console.WriteLine("2. Shoping center you are here");
                    Console.WriteLine("3. Shoting range 86,2km Away");
                    Console.WriteLine("4. Gas station 130km Away");
                    Console.Write("Enter your choice: ");
                    break;

                //gunrange menu
                case 3:
                    
                    Console.WriteLine("1. Small Shop 23,6km Away");
                    Console.WriteLine("2. Shoping center 86,2km Away");
                    Console.WriteLine("3. Shoting range you are here");
                    Console.WriteLine("4. Gas station 195km Away");
                    Console.Write("Enter your choice: ");
                    break;
            }
        }

        public void shopingcenter()
        {
            Console.WriteLine("you drive to the shoping center you found");
            for (int i = 0; i < 3; i++)
            {
                Loot.ShopingCenter();
            }
            Console.WriteLine("click to keep going");
            Console.ReadKey();
        }

        public void gunrange()
        {

            Console.WriteLine("you drive to the Gunrange you found");

            Loot.GunRange();
            Console.WriteLine("click to keep going");
            Console.ReadKey();

        }






    }   

        
}
