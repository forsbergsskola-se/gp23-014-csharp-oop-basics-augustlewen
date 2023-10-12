namespace P6GoodKnight;

public class Knight
{
    public Sword sword;
    public Shield shield;

    public void GetHit(Sword sword)
    {
        if(this.shield == null)
            Console.WriteLine("The Knight has no Shield and is wounded.");
        else
        {
            if(sword == null)
                Console.WriteLine("Knights Shield fends off the strike.");
            else
            {
                this.shield = null;
                Console.WriteLine("Knights Shield was pierced by the Sword.");
            }
            
        }
    }

    public void Attack(Knight target)
    {
        string weapon = this.sword != null? "sword" : "bare hands";
        Console.WriteLine($"Knight attacks Knight with {weapon}.");
        
        target.GetHit(this.sword);
    }
}



public class Sword
{
    
}

public class Shield
{
    
}