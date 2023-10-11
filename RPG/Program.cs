Monster monster = new Monster(3);
Player player = new Player(3);

Console.WriteLine(@$"You have {player.hp} Health.
You are fighting a monster with {monster.hp} Health.");

while (player.hp > 0)
{
    char input = GetUserInput();

    if (input == 'A')
        player.Attack(monster);
    else if (input == 'H')
        player.Heal();

    
    if (monster.hp > 0)
    {
        monster.Attack(player);
    }
    else
    {
        monster = new Monster(3);
        Console.WriteLine($"A new monster spawns with {monster.hp} Health");
    }
    
}

Console.WriteLine("GAME OVER!");


char GetUserInput()
{
    Console.WriteLine("What do you want to do? [A]ttack or [H]eal?");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine();

    return char.ToUpper(key.KeyChar);
}