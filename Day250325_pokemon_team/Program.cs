namespace Day250325_pokemon_team;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
}

public class Pokemon
{
    public string name;
    public string technology;
    
    public Pokemon(string name, string technology)
    {
        this.name = name;
        this.technology = technology;
    }

    public Pokemon()
    {
        
    }

    public virtual void Skill()
    {
        Console.WriteLine("{0}");
    }
    

}

public class Bulbasaur : Pokemon
{

    public override void Skill()
    {
        
        
    }
}
