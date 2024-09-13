Console.WriteLine("Welcome to my 1 v 1 game, pls follow the instructions for how to play below:"+"\n");
Console.WriteLine("Each player are going to have 100 hp in the beginning, and every punsh gives random power"+
", and every player has 3 healing bottles they can use after punshing!, press enter to start the game" + "\n");
Console.ReadLine();

//Creating player objects
Player p1 = new();
Player p2 = new();
//Creating object of 'Random' Class
Random random = new();

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

Player player;

while(p1.hp>0 && p2.hp>0){

    //Generating random numbers to each player
    p1.randomPunshPower = random.Next(10,80);
    p2.randomPunshPower = random.Next(10,80);

    //Player 1

    Console.WriteLine($"{p1.playerName}'s turn, press enter to punch" + "\n");
    Console.ReadLine();
    p2.playerPunshed();
    Console.WriteLine($"{p2.playerName} hp: {p2.hp}");
    Console.WriteLine($"{p2.playerName} heal bottles: {p2.amountHealthBottles}");
    if(p2.hp>0){
    Console.WriteLine("\n"+$"{p2.playerName}, do you want to use any health bottles? Yes or no?, writing random means 'no'");
    string healthBottleAns = Console.ReadLine().ToLower();
    if(healthBottleAns=="yes" && p1.hp>0){
        p2.playerHeals();
        p2.amountHealthBottles--;
        Console.WriteLine("\n"+$"{p2.playerName} hp: {p2.hp} Heal bottles: {p2.amountHealthBottles}" + "\n");
    }else{
        Console.WriteLine("\n");
    }
    }

    //Player 2

    Console.WriteLine($"{p2.playerName}'s turn, press enter to punch");
    Console.ReadLine();
    p1.playerPunshed();
    Console.WriteLine($"{p1.playerName} hp: {p1.hp}");
    Console.WriteLine($"{p1.playerName} heal bottles: {p1.amountHealthBottles}");
    if(p1.hp>0){
    Console.WriteLine("\n"+$"{p1.playerName}, do you want to use any health bottles? Yes or no?, writing random means 'no'");
    string healthBottleAns2 = Console.ReadLine().ToLower();
    
    if(healthBottleAns2=="yes" && p1.hp>0){
        p1.playerHeals(); 
        p1.amountHealthBottles--;
        Console.WriteLine($"{p1.playerName} hp: {p1.hp} Heal bottles: {p1.amountHealthBottles}" + "\n");
    }else{
        Console.WriteLine("\n");
    }
    }

}

if(p1.hp<=0){
    p1.playerDead();
    p2.playerVictory();
}
else if(p2.hp<=0){
    p2.playerDead();
    p1.playerVictory();
}

Console.WriteLine("\n"+"Press enter to end the game");

Console.ReadLine();








