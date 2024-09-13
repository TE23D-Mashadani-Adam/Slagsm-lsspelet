public class Player
{

    public double hp;
    public string playerName;
    public int randomPunshPower;
    public int amountHealthBottles;

    public void playerPunshed(){
        hp -= randomPunshPower;
    }
    public void playerHeals(){
            hp += 30;
    }
    public void playerDead(){
        Console.WriteLine(playerName+" is ");
        Console.WriteLine("""
 ____  _____    _    ____  
|  _ \| ____|  / \  |  _ \ 
| | | |  _|   / _ \ | | | |
| |_| | |___ / ___ \| |_| |
|____/|_____/_/   \_\____/ 
""" + "\n");
    }
    public void playerVictory(){
        Console.WriteLine("\n"+$"{playerName} has won the game!");
    }

}