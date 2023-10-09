Player playerA = new Player();

playerA.name = "August";
playerA.email = "agge.lewen@telia.com";

playerA.level = 99;
playerA.experience = 72050;

playerA.gold = 100;
playerA.stone = 55;
playerA.wood = 350;

playerA.subscription = false;
playerA.pvpEnabled = true;

Console.WriteLine($"Player A has {playerA.gold} Gold, {playerA.stone} Stone, {playerA.wood} Wood. " +
    $"He is level {playerA.level} and has {playerA.experience} Experience. He has an {(playerA.subscription? "active" : "inactive")} VIP subscription, " +
    $"and PVP {(playerA.pvpEnabled? "enabled" : "disabled")}. His display name is {playerA.name} and his e-mail address {playerA.email}");

public class Player
{
    public string name;
    public string email;
    
    public int level;
    public int experience;
    
    public int gold;
    public int stone;
    public int wood;

    public bool subscription;
    public bool pvpEnabled;
}