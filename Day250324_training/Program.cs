namespace Day250324_3;

class Program
{
    static void Main(string[] args)
    {
        Trainer trainer = new Trainer();

        for (int i = 0; i < 6; i++)
        {
            Console.Write("추가 포켓몬을 입력해주세요 : ");
            string monsterName = Console.ReadLine();
            Console.Write("추가 포켓몬 레벨을 입력해주세요: ");
            string input = Console.ReadLine();
            int level = 0;
            bool success = int.TryParse(input, out level);
            if(success)
            {
                Monster monster = new Monster(monsterName, level);
                trainer.Add(monster);
            }
            else
            {
                Console.WriteLine("잘못된 레벨 입력입니다. 해당 몬스터는 추가되지 않습니다.");
            }
        }
        
        Console.Write("삭제할 포켓몬을 입력해주세요 : ");
        string removeMonster = Console.ReadLine();
        trainer.Remove(new Monster(removeMonster));
        
        trainer.PrintAll();
        Console.WriteLine("프로그램 종료를 위해 아무 키나 누르세요.");
        Console.ReadKey();
    }
}

public class Monster
{
    public string name;
    public int level;
    
    public Monster(string _name)
    {
        name = _name;
    }

    // 생성자
    public Monster(string _name, int _level)
    {
        name = _name;
        level = _level;
    }

    // 함수
    public void Print()
    {
        Console.WriteLine("몬스터명: {0}, 레벨 : {1}",  name, level);
    }
    
    
}


public class Trainer
{
    private string name;
    private Monster[] monsters = new Monster[6];
        
    public Trainer()
    {
        Console.Write("플레이어를 입력해주세요 : ");
        name = Console.ReadLine();
    }
    
    public void Add(Monster monster)
    {
        for (int i = 0; i < monsters.Length; i++)
        {
            if (monsters[i] == null)
            {
                monsters[i] = monster;
                break;
            }
        }
    }
    
    public void Remove(Monster monster)
    {
        for (int i = 0; i < monsters.Length; i++)
        {
            if (monsters[i] != null && monsters[i].name == monster.name)
            {
                monsters[i] = null;
                break;
            }
        }
    }

    public void PrintAll()
    {
        Console.WriteLine("{0} 포켓몬 목록:", name);
        for (int i = 0; i < monsters.Length; i++)
        {
            if (monsters[i] != null)
            {
                monsters[i].Print();
            }
        }
    }
    
// /**
// [ 심화 ]
// - https://velog.io/@livelyjuseok/C-Struct%EC%99%80-Class%EC%9D%98-%EC%B0%A8%EC%9D%B4.-%EA%B7%B8%EB%A6%AC%EA%B3%A0-%EC%99%9C-%EC%82%AC%EC%9A%A9%ED%95%A0%EA%B9%8C
// - 기존 C언어에서는 Class라는 구분이 없이 Struct를 사용했다고 한다. 그렇기에 기존 C와 호환을 위해 Stuct를 사용한다.
// - 하지만 단순히 이러한 이유가 아닌 메모리 관리에 용이하다는 부분에서 계속 사용되고 있다.
// - ‘구조체 형식’은 데이터와 관련 기능을 캡슐화할 수 있는 값 형식
// - Struct는 Class와 유사하게 변수 선언, 함수 선언 등이 가능하지만 몇가지 차이점으로 인해 다르게 사용해야한다.
//
//
// 상속 여부
// - Class는 상속이 가능하지만, 구조체는 상속이 불가능하다.
//
// 형식의 차이
// - Struct는 값 타입(ValueType)이지만 Class는 참조(Reference Type)이다.
//
//
// [ 값, 참조 그리고 스텍과 힙]
// - 값 타입의 경우 스텍이라는 메모리 영역에 할당
// - 참조 타입은 힙에 할당하는 값의 주소 할당
//
// - 구조체는 사용을 할 때 부터 값 형식은 이미 스텍에 할당 되어있기에 바로 변수로 불러와 사용이 가능
//
// - Class는 new 키워드를 통해 힙 영역에 할당하고, 그 주소값을 참조하고 있어야한다.
//
// [  가비지 컬렉터 ]
// - C#의 특성상 힙에 할당된 메모리는 가비지 컬렉터라는 녀석이 사용하지 않는 애들을 정리 해주는데, 이때 처리해야할 양이 많으면 프로그램 동작 속도가 느려지거나 아예 멈추기도 한다.(*스텍은 사용 후 종료됨)
// - 그렇기에 굳이 힙에 할당하지 않아도 되는 건 스텍 메모리에서 사용하면 프로그램 속도 향상에 도움이 될 수 있다.
// - 스텍 메모리만 사용하자니 스텍 메모리는 제한이 있어 많이 사용할 경우 스텍오버플로우가 발생할 수 있으니 적절히 균형있게 사용하는게 좋다.
//
//
// [어느정도 까지 구조체를 사용하는게 좋을까?]
// - '적절히 균형있게'는 어느정도 인지 찾아보면 MSDN에서는 16바이트 미만일 경우를 추천
//
// - 여담 16바이트 이상은 힙에 할당?
// - 어떤 글들을 보다보면 16바이트 이상을 사용하면 struct라도 힙에 할당된다는 얘기도 있지만, 그 또한 아래 글에서 실험을 통해 아니라는걸 알려주고있다.
//
// https://www.sysnet.pe.kr/2/0/12619
// - 구조체의 크기가 16바이트를 넘어가면 힙에 할당된다고... 하는데... 아니... 도대체 그런 근거 없는 사실을 퍼뜨리고 있는 사람이 누굴까요? ^^;
// - 구조체는 크기가 어떻게 되었든 무조건 스택에 할당됩니다. 그래도, 말로만 하면 재미가 없으니 눈으로 확인할 수 있도록 테스트를 해봐야겠지요. ^^ 방법은, 다음과 같이 매우 간단합니다.
// ```
// using System;
// using System.Threading;
//
// public struct Size64
// {
//     public long l1;
//     public long l2;
//     public long l3;
//     public long l4;
//
//     public long l5;
//     public long l6;
//     public long l7;
//     public long l8;
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Thread t = new Thread(threadFunc);
//         t.IsBackground = true;
//         t.Start();
//
//         while (true)
//         {
//             int n = GC.CollectionCount(0) + GC.CollectionCount(1) + GC.CollectionCount(2);
//             Console.WriteLine(n);
//
//             Thread.Sleep(1000);
//         }
//     }
//
//     private static void threadFunc()
//     {
//         while (true)
//         {
//             Size64 variable = new Size64();
//         }
//     }
// }
//
// 0
// 0
// 0
// 0
// 0
// ...[생략]...
//
// 보다시피 threadFunc는 지속적으로 Size64 구조체를 new 시키고 있는데요, 따라서 16바이트가 넘어가는 구조체가 정말 힙에 할당된다면 Main에서 GC.CollectionCount를 구하는 코드에서 n 값은 계속 증가해야 합니다. 물론, 실행해 보면 n 값은 언제까지고 0으로만 나옵니다.
//
//     반대로 Size64를 구조체가 아닌 class로 정의하면,
//
// public class Size64
// {
//     public long l1;
//     public long l2;
//     public long l3;
//     public long l4;
//
//     public long l5;
//     public long l6;
//     public long l7;
//     public long l8;
// }
//
// // 0
// // 1984
// // 4420
// // 6959
// // 9454
// // 11650
// // 14186
// // ...[생략]...
//
// 이제는 GC.CollectionCount가 반환하는 n 값이 빠르게 증가하는 것을 확인할 수 있습니다.
//
//
//
//     혹시나 그럼, 어느 크기에선가는 heap으로 할당되지 않을까요? 이에 대한 답이 예전에 설명한 예제에 있습니다.
//
//     CER(Constrained Execution Region)이란?
//     ; https://www.sysnet.pe.kr/2/0/11868#large_sized_struct
//
// fixed 예약어를 사용하면 struct의 크기를 1MB 크기까지 간단하게 늘릴 수 있는데요,
//
// / 스택 크기 기본값 - 32비트 1MB, 64비트 4MB
// // 따라서 32비트로 빌드한 경우
//
// unsafe struct Big
// {
//     public fixed byte Bytes[1_048_576]; // 일반적인 스택 메모리의 크기가 1MB이므로 StackOverflowException 발생
// }
//
// 따라서, 위의 구조체를 생성하면 (stack에 할당을 시도하므로) StackOverflowException 예외가 발생합니다.
//
// // 32비트로 빌드한 경우
//
//     Big big = new Big(); // StackOverflowException 발생
//
// // 또는,
//
// Big big;  // 구조체의 특성상 new를 하지 않아도 할당하므로 StackOverflowException 발생
// ```
// */
    
}