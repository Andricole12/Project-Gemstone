using System;


public static class console_1
{

        public static Random rnd = new Random();
        public static int goldcount = 0;
        public static int silvercount = 0;
        public static int ironcount = 0;
        public static int coppercount = 0;
        public static int saltcount = 0;
        public static int stonecount = 0;
        public static int allcount = 0;
    public static void Main(){

        

        Console.WriteLine("==============================");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("a. Mine ores");
        Console.WriteLine("b. Check Inventory");
        Console.WriteLine("or (exit)");
        Console.WriteLine("==============================");
        switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("You continue mining for ores");
                    int orerng = console_1.rnd.Next(1, 100);
                    if (orerng <= 5){
                        Console.WriteLine("You found gold");
                        goldcount++;
                        Main();
                    } else if (orerng <= 13)
                    {
                        Console.WriteLine("You found Silver");
                        silvercount++;
                        Main();
                    }else if (orerng <= 25)
                    {
                        Console.WriteLine("You found iron");
                        ironcount++;
                        Main();
                    }else if (orerng <= 45)
                    {
                        Console.WriteLine("You found copper");
                        coppercount++;
                        Main();
                    }else if (orerng <= 65)
                    {
                        Console.WriteLine("You found salt");
                        saltcount++;
                        Main();
                    }else 
                    {
                        Console.WriteLine("You did not find any ores");
                        Console.WriteLine("But you atleast have stones");
                        stonecount++;
                        Main();
                    }
                    break;
                case "b":
                    inventory();
                    break;
                case "exit":
                    break;
                
            }
    }
    public static void inventory()
    {
        allcount = goldcount + ironcount + coppercount + saltcount + stonecount;
        Console.WriteLine("==============================");
        Console.WriteLine("Ores:");
        if (allcount == 0) 
        {
            Console.WriteLine("You don't have any ores womp womp");
        }else{};
        if (goldcount > 0) 
        {
            Console.WriteLine("Gold:" + goldcount);
        }else{};
        if (silvercount > 0) 
        {
            Console.WriteLine("Silver:" + silvercount);
        }else{};
        if (ironcount > 0) 
        {
            Console.WriteLine("Iron:" + ironcount);
        }else{};
        if (coppercount > 0) 
        {
            Console.WriteLine("Copper:" + coppercount);
        }else{};
        if (saltcount > 0) 
        {
            Console.WriteLine("Salt:" + saltcount);
        }else{};
        if (stonecount > 0) 
        {
            Console.WriteLine("Stone:" + stonecount);
        }else{};
        Console.WriteLine("==============================");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("a. go back");
        Console.WriteLine("==============================");
        switch(Console.ReadLine())
        {
            case "a":
                Main();
                break;
        }
    }
}