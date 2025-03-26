namespace Day250325;


class Program
{
    
    /**********************************************************************************
     * 상속 (Inheritance)
     *
     * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
     * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
     **********************************************************************************/

    // <상속>
    // 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
    // class 자식클래스 : 부모클래스
    class Monster
    {
        protected string name;
        public int hp;
        public float speed;

        public void Move()
        {
            Console.WriteLine("{0} 이/가 {1} 속도로 움직입니다.", name, speed);
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }
    }

    class Slime : Monster
    {
        public Slime()
        {
            name = "슬라임";
            hp = 10;
            speed = 3.5f;
        }

        public void Split()
        {
            Console.WriteLine("몸체를 두개로 분열합니다.");
        }
    }

    class Dragon : Monster
    {
        public Dragon()
        {
            name = "드래곤";
            hp = 100;
            speed = 10f;
        }

        public void Breath()
        {
            Console.WriteLine("브레스를 뿜습니다.");
        }
    }

    static void Main(string[] args)
    {
        Skill skill1 = new FireBall();
        Skill skill2 = new Smash();
        
        
        skill1.Execute();
        skill2.Execute();
        
        
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        // 부모클래스 Monster를 상속한 자식클래스는 모두 부모클래스의 기능을 가지고 있음
        slime.Move();
        dragon.Move();

        // 자식클래스는 부모클래스의 기능에 자식만의 기능을 더욱 추가하여 구현 가능
        slime.Split();
        dragon.Breath();

        
        // 업캐스팅 : 자식클래스는 부모클래스 자료형으로 암시적 형변환 가능
        Player player = new Player();
        player.Attack(slime);
        player.Attack(dragon);
        Monster monster = new Monster();
        monster.Move();
        
        
        Truck truck = new Truck();
        
        
        // 다운 캐스팅 (불가능한 경우가 있기 때문에 환인 후에 변환가능)
        // is : 형변환가능하면 true 아니면 false
        if (monster is Slime)
        {
            slime = (Slime)monster;
            slime.Split();
        }
        else if (monster is Dragon)
        {
            dragon = (Dragon)monster;
            dragon.Breath(); 
        }
        
        // as 형변환 가능하면 바꿔서 주고, 아니면 null
        Dragon dragon1 = monster as Dragon;
        
        
        
        
        
    }

        // 다형성
        // 객체의 속성이나 기능이 상황에 따라 여러가지 형태를 가질 수 있는 성질
        
    class Player
    {
        public int attackPoint;

        public void Attack(Monster monster)
        {
            monster.TakeDamage(attackPoint);
        }
    }



    // <상속 사용의미 1>
    // 상속을 진행하는 경우 부모클래스의 소스가 자식클래스에서 모두 적용됨
    // 부모클래스와 자식클래스의 상속관계가 적합한 경우 부모클래스에서의 기능 구현이 자식클래스에서도 어울림
    class Building
    {
        // 부모클래스에서 기능을 구현할 경우 모든 부모를 상속하는 자식클래스에 기능을 구현하는 효과
    }

    class Home : Building
    {
        // 자식클래스에서 자식클래스만의 기능을 구현
    }

    class School : Building
    {
        // 자식클래스에서 자식클래스만의 기능을 구현
    }



    // <상속 사용의미 2>
    // 업캐스팅을 통해 자식클래스는 부모클래스로 형변환이 가능함
    // 자식클래스는 부모클래스를 요구하는 곳에서 동일한 기능을 수행할 수 있음
    class Parent
    {
        public void Func() { }
    }
    class Child1 : Parent { }
    class Child2 : Parent { }
    class Child3 : Parent { }

    void UseParent(Parent parent) { parent.Func(); }
    void Main2()
    {
        Child1 child1 = new Child1();
        Child2 child2 = new Child2();
        Child3 child3 = new Child3();

        UseParent(child1);
        UseParent(child2);
        UseParent(child3);
    }
    
    class Car
    {
        public string name;
        public int speed;
        
        public Car()
        {
            Console.WriteLine("부모 생성자");
        }

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public void Move()
        {
            Console.WriteLine("{0} 자동차가 {1} 속도로 이동합니다.",name, speed);
        }
        
    }
    
    public class Skill
    {
        public string name;
        public float coolTime;

        public virtual void Execute()
        {
            Console.WriteLine("{0} 스킬을 사용합니다.", name);
            Console.WriteLine("{0} 쿨타임을 진행합니다.", coolTime);
        }
    }

    public class FireBall : Skill
    {
        public FireBall()
        {
            name = "파이어볼";
            coolTime = 1.5f;
            
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("화염구 발사");
        }
    }

    // <다형성의 사용의미 2>
    // 클래스간의 의존성을 줄여 확장성을 높임
    public class Smash : Skill
    {
        public Smash()
        {
            name = "강타";
            coolTime = 3f;
        }

        public void Execute()
        {
            Console.WriteLine("전방에 강력한 타격");
        }
        
    }
    
    class Truck : Car
    {
        public Truck()
        {
            Console.WriteLine("자식 생성자");
        }
    }
}

