namespace DesignPattern;

class Program
    {
        static void Main(string[] args)
        {
            
            MonsterBuilder orcArcherBuilder = new MonsterBuilder();
            orcArcherBuilder
                .SetName("오크 궁수")
                .SetWeapon("나무 활")
                .SetArmor("가죽 갑옷");

            MonsterBuilder orcWarriorBuilder = new MonsterBuilder();
            orcWarriorBuilder
                .SetName("오크 전사")
                .SetWeapon("나무 몽둥이")
                .SetArmor("철 갑옷");

            MonsterBuilder orcEliteWarriorBuilder = new MonsterBuilder();
            orcWarriorBuilder
                .SetName("오크 전사")
                .SetWeapon("철 검")
                .SetArmor("철 갑옷");

            MonsterBuilder.Monster monster0 = orcArcherBuilder.Build();
            Console.WriteLine("이름 : {0}, 무기 : {1}, 갑옷 : {2}", monster0.name, monster0.weapon, monster0.armor);

            MonsterBuilder.Monster monster1 = orcWarriorBuilder.Build();
            Console.WriteLine("이름 : {0}, 무기 : {1}, 갑옷 : {2}", monster1.name, monster1.weapon, monster1.armor);

            MonsterBuilder.Monster monster2 = orcEliteWarriorBuilder.Build();
            
            
            
            // 스테이지 1-1
            MonsterFactory level1Factory = new MonsterFactory();
            level1Factory.rate = 1;
            
            // 1. 처음 맵 만들어 졌을 때 -> 몬스터 3마리
            MonsterFactory.Monster monster11 = level1Factory.Create("슬라임");
            MonsterFactory.Monster monster33 = level1Factory.Create("슬라임");
            MonsterFactory.Monster monster55 = level1Factory.Create("슬라임");
            
           // 2. 다음 장소로 이동했을 때 -> 몬스터 5마리
            MonsterFactory.Monster monster12 = level1Factory.Create("슬라임");
            MonsterFactory.Monster monster22 = level1Factory.Create("슬라임");
            MonsterFactory.Monster monster3 = level1Factory.Create("슬라임");
            MonsterFactory.Monster monster4 = level1Factory.Create("고블린");
            MonsterFactory.Monster monster5 = level1Factory.Create("고블린");
            
            // 3. 보스룸 입장하면 -> 몬스터 2마리
            MonsterFactory.Monster bossMonster = level1Factory.Create("오크족장");
            MonsterFactory.Monster subMonster1 = level1Factory.Create("고블린");
            MonsterFactory.Monster subMonster2 = level1Factory.Create("고블린");
            
            
            // 스테이지 2-1
            MonsterFactory level2Factory = new MonsterFactory();
            level2Factory.rate = 1.1f;
            MonsterFactory.Monster level2monster1 = level2Factory.Create("슬라임");
            MonsterFactory.Monster level2monster2 = level2Factory.Create("슬라임");
            
            Build.GameObject gameObject =  new Build.GameObject();
                gameObject
                    .SetX(10)
                    .SetY(5)
                    .SetZ(3);
        }
    }

  