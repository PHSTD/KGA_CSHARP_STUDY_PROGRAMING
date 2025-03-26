using System.Runtime.CompilerServices;

namespace Day250325_training;

public abstract class Pokemon
{
    public string name;
    public int level;

    public Pokemon(string _name)
    {
        name = _name;
    }

    public abstract void Attack();
}

public class Pikachu : Pokemon
{
    // public string name = "피카츄";

    // public Pikachu(string _name) : base(name)
    // {
        // throw new NotImplementedException();
    // }

    public override void Attack()
    {
        Console.WriteLine($"{name} 백만볼트");
    }

    public Pikachu(string _name) : base(_name)
    {
        name = _name;
    }
}

public class Pidgey : Pokemon
{
    // public string name = "구구";
    
    public override void Attack()
    {
        Console.WriteLine($"{name} 에어슬래시");
    }

    public Pidgey(string _name) : base(_name)
    {
        name = _name;
    }
}

public class Geodude : Pokemon
{
    // public string name = "꼬마돌";
    
    public override void Attack()
    {
        Console.WriteLine($"{name} 돌떨구기");
    }

    public Geodude(string _name) : base(_name)
    {
        name = _name;
    }
}

public class Bulbasaur : Pokemon
{
    // public string name = "이상해씨";
    
    public override void Attack()
    {
        Console.WriteLine($"{name} 몸통박치기");
    }
    public Bulbasaur(string _name) : base(_name)
    {
        name = _name;
    } 
}

public class Charmander : Pokemon
{
    // public string name = "파이리";

    public override void Attack()
    {
        Console.WriteLine($"{name} 불꽃세례");

    }

    public Charmander(string _name) : base(_name)
    {
        name = _name;
    }
}

public class Squirtle : Pokemon
{
    // public string name = "꼬부기";
    
    

    public override void Attack()
    {
        Console.WriteLine($"{name} 물대포발사");
    }

    public Squirtle(string _name) : base(_name)
    {
        name = _name;
    }
}

class Trainer
{
    // public Pokemon[] pokemon;
    public Pokemon[] pokemon = new Pokemon[6];

    public void Pick(int num)
    {
        Console.WriteLine(pokemon[num].name);
    }

    public void Print()
    {
        for (int i = 0; i < pokemon.Length; i++)
        {
            Console.WriteLine(pokemon[i].name);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trainer trainer = new Trainer();
        
        Pikachu pikachu = new Pikachu("피카츄");
        Pidgey pidgey = new Pidgey("구구");
        Geodude geodude = new Geodude("꼬마돌");
        Bulbasaur bulbasaur = new Bulbasaur("이상해씨");
        Charmander charmander = new Charmander("파이리");
        Squirtle squirtle = new Squirtle("꼬부기");

        trainer.pokemon[0] = pikachu;
        trainer.pokemon[1] = pidgey;
        trainer.pokemon[2] = geodude;
        trainer.pokemon[3] = bulbasaur;
        trainer.pokemon[4] = charmander;
        trainer.pokemon[5] = squirtle;

        int index;

        bool chkNumber = false;
        while (chkNumber == false)
        {
            Console.WriteLine("0 ~ 6내로 입력해주세요"); 
            chkNumber = int.TryParse(Console.ReadLine(), out index);
            if (chkNumber && (index < 6))
            {
                trainer.Pick(index);
                chkNumber = true;
            }
            else
            {
               Console.WriteLine("===================================="); 
               Console.WriteLine("범위를 벗어났습니다."); 
               chkNumber = false;
            }
        }
        
        
       Console.WriteLine("===================================="); 
       Console.WriteLine("===================================="); 
       Console.WriteLine("===================================="); 
       Console.WriteLine("===================================="); 
        
        trainer.Print();
    }
}