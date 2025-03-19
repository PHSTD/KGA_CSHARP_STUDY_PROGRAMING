using System.Reflection.Metadata;

namespace Day250317_3;

class Program
{
    // Item 구조체
    // 내부에 아래와 같은 데이터를 가진다
    // 아이템 이름
    // 아이템 고유 ID
    struct Item
    {
        public string name;
        public string id;
    }

    // 2. Inventory 구조체
    struct Inventory
    {
        // 내부에 아래와 같은 데이터와 기능을 가진다
        // Item 구조체를 보관할 수 있는 배열
        public Item t1;

        // 인벤토리 생성 후 내부에서 관리하는 인벤토리의 배열에 대한 크기를 지정할 수 있어야 한다.
        public string[] t2;
    }
    
    static void Main(string[] args)
    {
        // Item 구조체를 입력 받아 이름과 고유 ID를 콘솔에 출력하는 함수 제작
        Item it;
        it.name = "홍길동";
        it.id = "193875804502";
        Console.WriteLine($"user name : {it.name}, user id : {it.id}");
        
        Console.WriteLine();
        Console.WriteLine();
        
        // Inventory 구조체를 입력받아 가지고 있는 아이템을 한줄에 하나씩 전부 출력하는 함수 제작
        Inventory iv;
        iv.t1.name = "홍길동";
        iv.t1.id = "193875804502";
        iv.t2 = new string[3];
        iv.t2[0] = "포션";
        iv.t2[1] = "방패";
        iv.t2[2] = "투구";

        Console.WriteLine(iv.t1.name);
        Console.WriteLine(iv.t1.id);
        for (int i = 0 ; i < iv.t2.Length ; i++)
        {
            Console.WriteLine(iv.t2[i]);
        }

    }

}