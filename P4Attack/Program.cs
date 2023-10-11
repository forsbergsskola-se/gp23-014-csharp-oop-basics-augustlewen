Player player1 = new Player("Player 1");
Player player2 = new Player("Player 2");
List<Player> players = new List<Player>() { player1, player2 };

player1.Attack(player2);
WritePlayersDamage();

player2.Attack(player1);
WritePlayersDamage();

player1.Attack(player1);
WritePlayersDamage();

Player player3 = player1;
player3.name = "Player 3";
players.Add(player3);

player2.Attack(player3);
WritePlayersDamage();



void WritePlayersDamage()
{
    foreach (Player player in players)
    {
          Console.WriteLine($"{player.name} Damage: {player.damage}");  
    }
}



public class Player
{
    public string name;
    public int damage;
    
    public void Attack(Player target)
    {
        target.damage++;
        Console.WriteLine($"{name} attacks {target.name}.");
    }

    public Player(string name)
    {
        this.name = name;
    }
}