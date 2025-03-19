namespace Day_250317_4;

class Program
{
    struct Skill
    {
        public string name;
        public float coolTime;
        public int cost;
        public float range;
    }

    enum Type
    {
        Normal,
        Elite,
        Boss
    }

    // 정보를 가진 박스이다
    // int 자료형도 구조체이다
    struct Monster
    {
        public string name;
        public int attack;
        public int defense;
        public float speed;
        public string[] items;
        public Type type;
        public string area;
    }

    
    static void Main(string[] args)
    {
        // 자료형 동일하게 가능
        int[] values = new int[4];
        Skill[] skils = new Skill[4];
        
        
        
        Monster orc;
        orc.name = "오크";
        orc.attack = 100;
        orc.defense = 50;
        orc.speed = 3.5f;
        orc.items = new string[] { "포션", "방패" };
        orc.area = "늪지";
        
        Console.WriteLine("{0} 몬스터가 등장합니다!!! {1} 데미지를 가합니다.", orc.name, orc.attack);
        
        Skill fireball;
        fireball.name = "파이어볼";
        fireball.coolTime = 2.5f;
        fireball.cost = 10;
        fireball.range = 3.5f;

        Skill smash;
        smash.name = "강타";
        smash.coolTime = 10f;
        smash.cost = 3;
        smash.range = 20f;
        
        Skill lance;
        lance.name = "창던지기";
        lance.coolTime = 1f;
        lance.cost = 0;
        lance.range= 1f;
        
        Skill ultimate;
        ultimate.name = "궁극기";
        ultimate.coolTime = 180f;
        ultimate.cost = 200;
        ultimate.range= 20f;

        skils[0] = fireball;
        skils[1] = smash;
        skils[2] = lance;
        skils[3] = ultimate;
        
        // Console.WriteLine(fireball.name);
        // Console.WriteLine("쿨타임은 {0} 입니다.", fireball.coolTime);

        while (true)
        {
            Console.Write("사용할 스킬 : ");
            string input =  Console.ReadLine();
            int value = int.Parse(input);
            
            Console.WriteLine("{0} 스킬을 사용합니다!!", skils[value].name);
            Console.WriteLine("마나가 {0} 감소합니다!!", skils[value].cost);
            Console.WriteLine("쿨타임을 {0} 초 돌립니다!!", skils[value].coolTime);
            Console.WriteLine("공격 범위 {0} 을 확인합니다!!", skils[value].range);

        }

    }
}