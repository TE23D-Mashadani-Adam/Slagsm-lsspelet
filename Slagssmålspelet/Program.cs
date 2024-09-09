Console.WriteLine("Welcome to my 1 v 1 game, pls follow the instructions for how to play below:"+"\n");
Console.WriteLine("Each player are going to have 100 hp in the beginning, and every punsh gives random power"+
", and every player has 3 healing bottles they can use after punshing!, press enter to start the game");
Console.ReadLine();

//Creating player objects
Player p1 = new();
Player p2 = new();

//Assigning health and amount healing bottles
p1.hp = 100;
p2.hp = 100;

p1.amountHealthBottles = 3;
p2.amountHealthBottles = 3;

//Writing down players names
Console.WriteLine("Write player 1 name:");
string p1Name = Console.ReadLine();
p1.playerName = p1Name;
Console.WriteLine("Write player 2 name:");
string p2Name = Console.ReadLine();
p2.playerName = p2Name;

while(p1.hp>0 && p2.hp>0){
    Console.WriteLine($"{p1.playerName} starts punching");
    p2.playerPunshed();
    Console.WriteLine($"{p1.playerName} hp: {p1.hp}");
    Console.WriteLine($"{p1.playerName} heal bottles: {p1.amountHealthBottles}");
    Console.WriteLine("\n"+"Do you want to use any health bottles? Yes or no?, writing random means 'no'");
    string healthBottleAns = Console.ReadLine().ToLower();
    if(healthBottleAns=="yes"){
        p1.hp += 30;
        p1.amountHealthBottles--;
    }
    

}

Console.ReadLine();








