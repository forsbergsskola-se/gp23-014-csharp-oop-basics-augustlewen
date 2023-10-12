using P6GoodKnight;

Knight attacker = new Knight();
Knight defender = new Knight();


// Create two Knight, attcker and defender.
//
//     Give defender an Shield
//
// Let attacker Attack defender
//
// Give attacker a Sword
//
// Let attacker Attack defender
//
// Let attacker Attack defender

defender.shield = new Shield();

attacker.Attack(defender);

attacker.sword = new Sword();

attacker.Attack(defender);

attacker.Attack(defender);
