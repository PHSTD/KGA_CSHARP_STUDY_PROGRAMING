namespace DesignPattern;

public class MonsterFactory
{
    public float rate;

    public Monster Create(string name)
    {
        Monster monster;
        switch (name)
        {
            case "슬라임":    monster = new Monster("슬라임", 1, 100);       break;
            case "고블린":    monster = new Monster("고블린", 3, 200);       break;
            case "오크족장":  monster = new Monster("오크족장", 10, 2000);   break;
            default: return null;
        }

        monster.hp = (int)(monster.hp * rate);
        return monster;
    }

    public class Monster
    {
        public string name;
        public int level;
        public int hp;

        public Monster(string name, int level, int hp)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
        }
    }
}