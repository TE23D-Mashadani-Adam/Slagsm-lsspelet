public class Player
{

    public double hp;
    public string playerName;
    public int randomPunshPower;
    public int amountHealthBottles;
    public bool isDead = false;

    public void playerPunshed()
    {
        hp -= randomPunshPower;
    }
    public void playerPunchScene(Player player, Random random)
    {
        player.randomPunshPower = random.Next(10,80);

        Console.WriteLine($"{player.playerName}'s turn, press enter to punch" + "\n");
        Console.ReadLine();
        player.playerPunshed();
        Console.WriteLine($"{player.playerName} hp: {player.hp}");
        Console.WriteLine($"{player.playerName} heal bottles: {player.amountHealthBottles}");
        if (player.hp > 0)
        {
            Console.WriteLine("\n" + $"{player.playerName}, do you want to use any health bottles? Yes or no?, writing random means 'no'");
            string healthBottleAns = Console.ReadLine().ToLower();
            if (healthBottleAns == "yes" && player.isDead == false)
            {
                player.playerHeals();
                player.amountHealthBottles--;
                Console.WriteLine("\n" + $"{player.playerName} hp: {player.hp} Heal bottles: {player.amountHealthBottles}" + "\n");
            }
            else
            {
                Console.WriteLine("\n");
            }
        }
    }
    public void playerHeals()
    {
        hp += 30;
    }
    public void playerDead()
    {
        Console.WriteLine(playerName + " is ");
        Console.WriteLine("""
 ____  _____    _    ____  
|  _ \| ____|  / \  |  _ \ 
| | | |  _|   / _ \ | | | |
| |_| | |___ / ___ \| |_| |
|____/|_____/_/   \_\____/ 
""" + "\n");
    }
    public void playerVictory()
    {
        Console.WriteLine("\n" + $"{playerName} has won the game!");
    }

}