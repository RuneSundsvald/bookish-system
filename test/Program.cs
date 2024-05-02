using test;
bool exit = false;
double FillTank;
double InTank=0;
Console.WriteLine("how much do you tank in L?");
bool TryFail = double.TryParse(Console.ReadLine(),out FillTank);
if(!TryFail) Console.WriteLine("not a number FAIL");
InTank=FillTank+InTank;
Bil player = new Bil();
PlaceMenu menu = new PlaceMenu();
LootTables Loot = new LootTables();
Gas gas = new Gas();
double GasUsed;
int PlayerLastSeen = 0;
int PlayerGoingToo;

while (!exit)
{   Console.Clear();
    //lets the player know how much gas they have left
    player.FuleATM(InTank);

    //loads the menu for start or the POI the player is at
    menu.Menu(PlayerLastSeen);

    
    string input = Console.ReadLine();
    
    
    
    
    switch (input)
    {
        //Small shop
        case "1":
            //This is used in to find out how much gas is used
            PlayerGoingToo = int.Parse(input);

            //Writes out the menu + loot for the POI small shop
            menu.smallshop();
           

            //takes data from the players last know locasion and where the player is going to find out how much gas is used
            GasUsed = gas.gasfromto(PlayerLastSeen,PlayerGoingToo);

            //finds out how much gas the player has left
            InTank = player.Drive(GasUsed, InTank);

            //if player is out of gas game over
            if (InTank<=0)
            {
                Console.WriteLine("gameover you are out of gas");
                Console.ReadKey();
                exit = true;
            }

            //updates player locasion
            PlayerLastSeen = PlayerGoingToo;
            
            //TEMP end
            //exit = true;
            break;
        
        //Shoping center
        case "2":
            
            //This is used in to find out how much gas is used
            PlayerGoingToo = int.Parse(input);

            //Writes out the menu + loot for the POI shoping center
            menu.shopingcenter();
            

            //takes data from the players last know locasion and where the player is going to find out how much gas is used
            GasUsed = gas.gasfromto(PlayerLastSeen, PlayerGoingToo);

            //finds out how much gas the player has left
            InTank = player.Drive(GasUsed, InTank);
            
            //if player is out of gas game over
            if (InTank <= 0)
            {
                Console.WriteLine("gameover you are out of gas");
                Console.ReadKey();
                exit = true;
            }

           
            //updates player locasion
            PlayerLastSeen = PlayerGoingToo;

            //TEMP end
            //exit = true;
            break;

        //Gunrange
        case "3":
            //This is used in to find out how much gas is used
            PlayerGoingToo = int.Parse(input);

            //Writes out the menu + loot for the POI gunrange
            menu.gunrange();


            //takes data from the players last know locasion and where the player is going to find out how much gas is used
            GasUsed = gas.gasfromto(PlayerLastSeen, PlayerGoingToo);

            //finds out how much gas the player has left
            InTank = player.Drive(GasUsed, InTank);

            //if player is out of gas game over
            if (InTank <= 0)
            {
                Console.WriteLine("gameover you are out of gas");
                Console.ReadKey();
                exit = true;
            }

          
            //updates player locasion
            PlayerLastSeen = PlayerGoingToo;

            //TEMP end
            //exit = true;
            break;

        //finish
        case "4":
            PlayerGoingToo = int.Parse(input);
            Console.WriteLine("you won!!! ");
            GasUsed = gas.gasfromto(PlayerLastSeen, PlayerGoingToo);
            InTank = player.Drive(GasUsed, InTank);
            player.FuleATM(InTank);
            exit = true;
            break;
        //default
        default:
            Console.WriteLine("Invalid option. Please select a valid option (1-4).");
            break;
    }

}
