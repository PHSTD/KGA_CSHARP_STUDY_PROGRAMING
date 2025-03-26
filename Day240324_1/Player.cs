namespace Day240324_1;

public class Player
{
    public int ap = 10;

    public void Attack(Monster monster)
    {
        monster.TakeHit(ap);
    }

}