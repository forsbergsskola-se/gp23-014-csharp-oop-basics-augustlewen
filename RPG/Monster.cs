public class Monster
{
    public int hp;

    public void Attack(Player target)
    {
        target.hp--;
        Console.WriteLine($"The monster attacks you, you have {target.hp} health");

    }
    
    public Monster(int hp)
    {
        this.hp = hp;
    }
}