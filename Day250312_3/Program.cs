namespace Day250312_3;

class Program
{
    static void Main(string[] args)
    {
        ShowIntro();
        SetPath();
    }
    
       static void ShowIntro()
    {
        Console.WriteLine("TEXT RPG");
        Console.WriteLine("1. 모험시작");
        Console.WriteLine("2. 설정");
        Console.WriteLine("3. 게임 끄기");
        
        Console.Write("선택지를 입력해 주세요 : ");
        int integer = int.Parse(Console.ReadLine());

        if (integer == 1)
        {
            StartGame();
        }
        else if (integer == 2)
        {
            
            SetPath();
        }
        else if (integer == 3)
        {
            EndGame();
        }
    }

    static void SetPath()
    {

           Console.WriteLine("1.소리설정"); 
           Console.WriteLine("2.글꼴설정"); 
           Console.WriteLine("3.뒤로가기"); 
           
           int ch1 = int.Parse(Console.ReadLine());

           if (ch1 == 1)
           {
               Console.WriteLine("소리 설정 했습니다");
               Console.Write("음향을 설정 해주세요(1 ~ 5) : ");
               int sound = int.Parse(Console.ReadLine());
               Console.WriteLine("{0}으로 설정 완료 했습니다.", sound);
               if (sound == 1)
               {
                   Console.WriteLine("\u25a0 \u25a1 \u25a1 \u25a1 \u25a1");
               }
               else if (sound == 2)
               {
                   Console.WriteLine("\u25a0 \u25a0 \u25a1 \u25a1 \u25a1");
               }
               else if (sound == 3)
               {
                   Console.WriteLine("\u25a0 \u25a0 \u25a0 \u25a1 \u25a1");
               }
               else if (sound == 4)
               {
                   Console.WriteLine("\u25a0 \u25a0 \u25a0 \u25a0 \u25a1");
               }
               else if (sound == 5)
               {
                   Console.WriteLine("\u25a0 \u25a0 \u25a0 \u25a0 \u25a0");
               }

               ShowIntro();
           }
    }
    
    static void EndGame()
    {
       Console.WriteLine("안녕히가세요"); 
    }

    static void StartGame()
    {
    
           Console.WriteLine("=== 모험 시작 ==="); 
           Console.WriteLine("1. 공격"); 
           Console.WriteLine("2. 방어"); 
           Console.WriteLine("3. 도망"); 
           
           int cho = int.Parse(Console.ReadLine());

           if (cho == 1)
           {
               Console.WriteLine("공격했습니다."); 
           }
           else if (cho == 2)
           {
               Console.WriteLine("방어했습니다."); 
           }
           else if (cho == 3)
           {
               Console.WriteLine("도망갔습니다."); 
           }
    }
}