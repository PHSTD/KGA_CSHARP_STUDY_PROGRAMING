namespace Day240324_1;

public class Monster
{
    public int hp;

    public void TakeHit(int damage)
    {
        hp -= damage;
    }
}