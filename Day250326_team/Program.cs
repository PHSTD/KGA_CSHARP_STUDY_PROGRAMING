namespace Day250326_team;

public abstract class Item
{
    public abstract void Use();
}

class Npc : Iintact, Ihit
{
    private string name;
    private string type;

    public void Talk()
    {
        switch (type)
        {
            case "Merchant":
            case "merchant":
                Console.WriteLine("상점을 열었습니다.");
                break;
            
            default:
                Console.WriteLine("NPC와 대화를 합니다.");
                break;
        }
    }

    public void hit()
    {
        RunNpc();
    }

    public void RunNpc()
    {
        Console.WriteLine("NPC가 도망갔습니다.");
    }

    public void TypeChange(string _type)
    {
        type = _type;
    }
    
    public void intact()
    {
        Talk();
    }
}

class ItemBox : Iintact, Ihit
{
    private string name;
    private string[] item;

    public void intact()
    {
        acquire();
    }

    public void hit()
    {
        acquire();
    }
    
    public void acquire()
    {
        Console.WriteLine("아이템을 습득했습니다.");
    }
}

class Door : Iintact, Ihit
{
    public void Move()
    {
        Console.WriteLine("다음 게이트로 이동합니다.");
    }

    public void intact()
    {
        Move();
    }

    public void hit()
    {
        Console.WriteLine("문을 부셨습니다.");
    }
}

class Player
{
    private int level;
    private string name;
    private string job;
    
    public void intact(Iintact intact)
    {
        intact.intact();
    }

    public void hit(Ihit hit)
    {
        hit.hit();
    }
}

class Monster
{
    private string name;
    private int level;
    private int hp;

    public void hit(Ihit hit)
    {
        hit.hit();
    }

}

public interface Ihit
{
    public void hit();
}

public interface Iintact
{
    public void intact();
}

class Program
{
    static void Main()
    {
        Player player = new Player();
        Monster monster = new Monster();
        
        
        Npc npc = new Npc();
        ItemBox itemBox = new ItemBox();
        Door door = new Door();
        
        
        player.intact(npc);
        player.intact(door);
        npc.TypeChange("Merchant");
        player.intact(npc);
        player.intact(itemBox);
        
        monster.hit(door);
        monster.hit(itemBox);
        player.hit(npc);
        monster.hit(npc);
    }
}