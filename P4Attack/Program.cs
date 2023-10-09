List<Player> players = new List<Player>();
Player player1 = new Player("Player 1");
Player player2 = new Player("Player 2");
players.Add(player1);
players.Add(player2);

Attack(player1, player2);
Attack(player2, player1);
Attack(player1, player1);

Player player3 = player1;
player3.name = "Player 3";
players.Add(player3);
Attack(player2, player3);


void WritePlayersDamage()
{
    foreach (Player player in players)
    {
          Console.WriteLine($"{player.name} Damage: {player.damage}");  
    }
}


void Attack(Player source, Player target)
{
    target.damage++;
    Console.WriteLine($"{source.name} attacks {target.name}.");
    WritePlayersDamage();
}
public class Player
{
    public string name;
    public int damage;
    
    

    public Player(string name)
    {
        this.name = name;
    }
}