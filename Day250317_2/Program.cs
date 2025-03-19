namespace Day250317_2;

class Program
{
    enum RockPaperScissor
    {
        Rock = 1,
        Paper = 2,
        Scissor = 3
    }
    enum Elemental
    {
        Fire,
        Water,
        Grass,
        Electric,
        Rock,
        Normal
    }

    enum Equipment
    {
        Head,
        Body,
        Foot,
        Arm,
        Part2,
        Size
    }
    
    static void Main(string[] args)
    {
        // 특징
        // 열거형은 사용자가 담는 자료형(enum, class 등)
        // 열거형은 사람이 헷갈리지 않게 만들어진것 사실 돌아갈땐 정수로 돌아간다, 변수 위에 마우스 올리면 순서대로 0,1,2 이런식으로 부여되어있다
        // 즉 정수에다 별명을 붙이는것
        
        // 시작 정수 변경은  저정하고 싶으면 열거형 순서에 = 원하는숫자 하나씩 플러스 되면서 부여 되는것을 볼수있다
        
        // 틀린경우 어디서 틀렸는지 코드에서 오류를 찾아야 한다
        // 범위나 숫자만 보고 알기 어렵다
        // 그렇다고 문자열로 관리하면 틀리진 않겠지만 오타가 있을수도 있고 만든 의도 틀리게 이해해서 잘 못 작성할수도 있다.
        
        // 이럴때 사용하는것이 열거형이다
        // 숫자에 별명을 붙여 알아보기 쉽게 만들고 그 외 사용불가하게 만드는 것이다.
        
        // 형변환 1
        RockPaperScissor com1 = (RockPaperScissor)2;
        Console.WriteLine(com1);
        // 형변환 2
        int com2 = (int)RockPaperScissor.Paper;
        Console.WriteLine(com2);
        
        
        // 장비칸
        string[] equipments = new string[(int)Equipment.Size];
        
        equipments[(int)Equipment.Head] = "철투구";
        equipments[(int)Equipment.Body] = "철갑옷";
        
        // ------
        
        RockPaperScissor commend= RockPaperScissor.Rock;
        
        Console.WriteLine("묵찌빠!!");
        Console.WriteLine("1. 묵, 2. 찌, 3. 빠");
        string input = Console.ReadLine();
        Enum.TryParse(input, out commend);
        switch (commend)
        {
            case RockPaperScissor.Scissor:
                Console.WriteLine("가위를 냅내다");
                break;
            case RockPaperScissor.Rock:
                Console.WriteLine("바위를 냅내다");
                break;
            case RockPaperScissor.Paper:
                Console.WriteLine("보를 냅내다");
                break;
            default:
                Console.WriteLine("잘못 냈다");
                break;
        }



        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("             ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("             ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("test");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("test");
        Console.ResetColor();
        
    }
    
}