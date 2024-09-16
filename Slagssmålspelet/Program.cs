using System.Security.Cryptography.X509Certificates;

bool continuePlaying = true;



while(continuePlaying){

Console.WriteLine("Welcome to my 1 v 1 game, pls follow the instructions for how to play below:" + "\n");
Console.WriteLine("Each player are going to have 100 hp in the beginning, and every punsh gives random power" +
", and every player has 3 healing bottles they can use after punshing!, press enter to start the game" + "\n");
Console.ReadLine();



//Creating player objects
Player p1 = new();
Player p2 = new();
//Creating object of 'Random' Class
Random random = new();

//Assign player names method
void assignPlayerNames(){
    Console.WriteLine("Write player 1 name:");
string p1Name = Console.ReadLine();
p1.playerName = p1Name;
Console.WriteLine("Write player 2 name:");
string p2Name = Console.ReadLine();
p2.playerName = p2Name;
}

//Assigning health and amount healing bottles
p1.hp = 100;
p2.hp = 100;

p1.amountHealthBottles = 3;
p2.amountHealthBottles = 3;

 void checkIfPlayerDead()
{
    if (p1.hp <= 0)
    {
        p1.isDead = true;
    }
    else if (p2.hp <= 0)
    {
        p2.isDead = true;
    }
}

//Writing down players names

assignPlayerNames();

while (p1.hp > 0 && p2.hp > 0)
{

    checkIfPlayerDead();

    //Player 1
    if (p2.isDead == false && p1.isDead == false)
    {
        p1.playerPunchScene(p1, random);
    }

    checkIfPlayerDead();

    //Player 2
    if (p1.isDead == false && p2.isDead == false)
    {
       p2.playerPunchScene(p2, random);
    }


}

if (p1.hp <= 0)
{
    p1.playerDead();

    p2.playerVictory();
}
else if (p2.hp <= 0)
{
    p2.playerDead();
    p1.playerVictory();
}

Console.WriteLine("\n" + "Press enter to restart the game, write anything to exit game");
String ansRestart = Console.ReadLine();

if(ansRestart == String.Empty){
    continuePlaying = true;
}else{
    continuePlaying = false;
    break;
}

}
Console.ReadLine();








