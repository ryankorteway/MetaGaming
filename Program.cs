namespace MetaGaming;
class Program
{
    static void Main(string[] args)
    {
        string? PlayerInput;
        //Initial game explanation
        Console.WriteLine("Welcome to Metagaming.");
        Console.WriteLine("This is a text based escape game where commands entered here generate output and ultimately progress the story.");
        Console.WriteLine("Commands are case sensitive and some are common to computer terminals while others are intentionally obscure.");
        Console.WriteLine("Press any key to continue once you understand.");
        Console.ReadKey(); 

        Console.Clear();
       
        //Initial game Exposition
        Console.WriteLine("You wake up in a room, 4 white walls, one with a door that's locked, a gray concrete floor,");
        Console.WriteLine("and a bare metal ceiling with humming fluorescent lights overhead.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Beyond the bare basic room construction, you have a computer on a desk showing what you now see on your own screen.");
        Console.WriteLine("Running between the back of the computer and the door is a thick metal tube. With no other clear options, you sit at the computer.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue once you understand.");
        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("After this point, enter an empty line or type rageQuit to exit the game for now.");
        Console.WriteLine();
        Console.WriteLine();    

        while (true)
        {
            Console.Write("Command: "); 
            PlayerInput = Console.ReadLine();
            if(PlayerInput==null||PlayerInput==""||PlayerInput=="rageQuit"){
                Console.WriteLine("Thanks for playing. I hope you come back to play and reach the True End soon.");
                return;
            } else {
                //Rest of the game stuff here.
                if(PlayerInput=="exIT") Console.WriteLine("One Step closer but you need to dig DEEPER.");
                if(PlayerInput=="help") Console.WriteLine("DnSpy is your friend, try looking into the game with DnSpy.exe from Github.");
                if(PlayerInput=="version") Console.WriteLine("Version: Whatever.I.Want");

                //Youtuber Easter Eggs
                //For Jack
                if(PlayerInput=="SepticEye") Console.WriteLine("**WAAAP** TOP OF THE MORNING TO YA LADDIES!!!");
                
                //For CaptainS
                if(PlayerInput=="Creeper") Console.WriteLine("Creeper? AWW MAN!");

                //For Mark
                if(PlayerInput=="Chica") Console.WriteLine("Chica is such a good doggo");

                //For Unexpectables
                if(PlayerInput=="Wark") Console.WriteLine("Wark");

                //For Unexpectables
                if(PlayerInput=="Praise") Console.WriteLine("PRAISE OREYARA");

                //For Gaijin
                if(PlayerInput=="Goomba") Console.WriteLine("Hey Guys, Gaijin Goomba Here!");

                if(PlayerInput=="DEEPER") {
                    DEEPER FollowMe = new DEEPER();
                    Console.WriteLine(FollowMe.DeeperStr);
                    return;
                } 
            }
        }
    }
}
