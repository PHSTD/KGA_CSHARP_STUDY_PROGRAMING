using System.Diagnostics;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;

namespace Day250319_1;

class Program
{

    struct PlayerPos
    {
        public int x;
        public int y;
    }
    
    static void Main()
    {
        
        Console.WriteLine("----- 디지몬 ----- ");
        Console.WriteLine("1. 디지털 세계로 진입(시작) ");
        Console.WriteLine("2. 디지바이스(설정) ");
        Console.WriteLine("0. 디지털 세계 나가기(종료) ");

        PlayerPos playerPos;
        playerPos.x = 0;
        playerPos.y = 0;

        bool gameOver = false;
        while (gameOver == false)
        {
            int z;
            int.TryParse(Console.ReadLine(), out z);
            
            switch (z)
            {
                case 1:
                    Start(playerPos);
                    break;
                
                case 2:
                    
                    break;
                
                case 0:
                    End();
                    break;
                    
                default:
                    OverRange();
                    break;
            }
        }
    }



    static void Start(PlayerPos playerPos)
    {
        Console.CursorVisible = false;
        Render(playerPos);
    }
    
   static void boolReverse (ref bool boo)
   {
       boo = !boo;
   }
    
    static void End()
    {
        // Console.Clear();
        Console.Write("게임이 종료 되었습니다.");
        Environment.Exit(0);
    }

    static void Render(PlayerPos playerPos)
    {
        int myClLv = 2;
        bool typeCH = true;
        
        Console.WriteLine("몇 단계로 시작하시겠습니까?");
        Console.WriteLine("1. 레벨 1(클리어)");
        Console.WriteLine("2. 레벨 2(클리어)");
        Console.WriteLine("3. 레벨 3");
        Console.WriteLine("4. 레벨 4(실행 불가)");
        Console.WriteLine("5. 레벨 5(실행 불가)");
        Console.WriteLine("0. 메인으로");
        
        while (true)
        {
            float z;
            float.TryParse(Console.ReadLine(), out z);
            if (
                z == 1.0f ||
                z == 2 ||
                z == 3 ||
                z == 4 ||
                z == 5
            )
            {
                // 클리어 하지 않은 맵 막기
                MapLevel(z, myClLv, playerPos);
            }
            // TODO: 엔터를 0으로 인식함 
            else if (z == 0.0f)
            {
                // main 화면으로 이동
                Main();
                // break;
            }
            else
            {
                // 값이 없는 값이나 문자를 입력했을 떄
                OverRange();
            }
        }

    }
        
    // 지정하기 않은 맵 이나 키를 선택한 경우
    static void OverRange()
    {
        Console.WriteLine("범위를 벗어났습니다.");
    }
    
    
    // 클리어 하지 않음 맵
    static void NoNextMap()
    {
        Console.WriteLine("지금은 실행할 수 없는 맵 입니다.");
    }
    
    static bool MapLevelCheck(float mapLevel, int myClLv)
    {
        if (mapLevel > ++myClLv)
        {
            NoNextMap();
            return false;
        }

        return true;
    }
    
    static void MapLevel(float level, int myClLv, PlayerPos playerPos)
    
    {
        bool bol = MapLevelCheck(level, myClLv);

        if (bol)
        {
            MapPrint(level, playerPos);
        }

        // boolReverse(ref bol);
    }

    static void MapPrint(float level, PlayerPos playerPos)
    {
        char[,] map = new char[,] { };
        
        switch (level)
        {
            case 1:
                
                map = new char[10,20]{
                    {'@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','@'},
                    {'@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@','@'},
                };
                
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            
            default:
                OverRange();
                break;
        }
        
        // 예시: 맵 데이터 출력
        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                Console.Write(map[row, col]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    
    static void Input()
    {
        
    }

    static void Move()
    {
        
    }
    
}