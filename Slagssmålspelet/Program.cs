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
console.WriteLine("Write player 1 name:");
string p1Name = console.ReadLine();
p1.playerName = p1Name;
console.WriteLine("Write player 2 name:");
string p2Name = console.ReadLine();
p2.playerName = p2Name;








