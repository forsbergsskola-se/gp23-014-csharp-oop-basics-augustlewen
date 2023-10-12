using P6GoodKnight;

Knight attacker = new Knight();
Knight defender = new Knight();


defender.shield = new Shield();

attacker.Attack(defender);

attacker.sword = new Sword();
Console.WriteLine("Equipping sword...");

attacker.Attack(defender);

attacker.Attack(defender);
