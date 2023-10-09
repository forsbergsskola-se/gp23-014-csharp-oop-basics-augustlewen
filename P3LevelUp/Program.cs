Player player = new Player();

while (true)
{
    Console.WriteLine($"{player.level} Level and {player.experience} Experience");
    player.experience += GetInputValue();
    LevelUpCheck();
}

void LevelUpCheck()
{
    if (player.experience >= 100)
    {
        player.level++;
        player.experience -= 100;
        LevelUpCheck();
    }
}

int GetInputValue()
{
    int value = 0;
    while (value == 0)
    {
        string input = Console.ReadLine();
        if (!int.TryParse(input, out value))
            value = 0;

        if (value <= 0)
            value = 0;

    }

    return value;
}




public class Player
{
    public int experience;
    public int level;
}