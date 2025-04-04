namespace DesignPattern;

public class MonsterBuilder
{
    
    public string name;
    public string weapon;
    public string armor;

    public MonsterBuilder()
    {
        name = "몬스터";
        weapon = "기본무기";
        armor = "기본갑옷";
    }

    public Monster Build()
    {
        Monster monster = new Monster();
        monster.name = name;
        monster.weapon = weapon;
        monster.armor = armor;

        return monster;
    }

    public MonsterBuilder SetName(string name)
    {
        this.name = name;
        return this;
    }

    public MonsterBuilder SetWeapon(string weapon)
    {
        this.weapon = weapon;
        return this;
    }

    public MonsterBuilder SetArmor(string armor)
    {
        this.armor = armor;
        return this;
    }

    public class Monster
    {
        public string name;
        public string weapon;
        public string armor;
    }
}