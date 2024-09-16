public class Player
{

    public double hp;
    public string playerName;
    public int randomPunshPower;
    public int amountHealthBottles;
    public bool isDead = false;

    public void playerPunshed(int randomPunchPower)
    {
        hp -= randomPunchPower;
    }
    public void playerPunchScene(Player punchingPlayer, Player punshedPlayer, Random random, int randomPunchPower)
    {
        randomPunchPower = random.Next(10,80);

        Console.WriteLine($"{punchingPlayer.playerName}'s turn, press enter to punch" + "\n");
        Console.ReadLine();
        punshedPlayer.playerPunshed(randomPunchPower);
        Console.WriteLine($"{punshedPlayer.playerName} hp: {punshedPlayer.hp}");
        Console.WriteLine($"{punshedPlayer.playerName} heal bottles: {punshedPlayer.amountHealthBottles}");
        if (punshedPlayer.hp > 0 && punshedPlayer.amountHealthBottles > 0)
        {
            Console.WriteLine("\n" + $"{punshedPlayer.playerName}, do you want to use any health bottles? Yes or no?, writing random means 'no'");
            string healthBottleAns = Console.ReadLine().ToLower();
            if (healthBottleAns == "yes")
            {
                punshedPlayer.playerHeals();
                punshedPlayer.amountHealthBottles--;
                Console.WriteLine("\n" + $"{punshedPlayer.playerName} hp: {punshedPlayer.hp} "+ 
                $"Heal bottles: {punshedPlayer.amountHealthBottles}" + "\n");
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