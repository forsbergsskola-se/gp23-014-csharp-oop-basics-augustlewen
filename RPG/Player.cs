public class Player
{
    public int hp;

    public void Attack(Monster target)
    {
        target.hp--;
        Console.WriteLine($"You attack the monster, it has {target.hp} health");
    }

    public void Heal()
    {
        hp += 3;
        Console.WriteLine("You heal yourself to recover 3 Health");
    }

    public Player(int hp)
    {
        this.hp = hp;
    }
}