using System.Diagnostics;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;

namespace Day250319_1;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("----- 디지몬 ----- ");
        Console.WriteLine("1. 디지털 세계로 진입(시작) ");
        Console.WriteLine("2. 디지바이스(설정) ");
        Console.WriteLine("3. 디지털 세계 나가기(종료) ");

        bool gameOver = false;
        while (gameOver == false)
        {
            int z;
            int.TryParse(Console.ReadLine(), out z);
            
            switch (z)
            {
                case 1:
                    Start();
                    break;
                
                case 2:
                    
                    break;
                
                case 3:
                    End();
                    break;
                    
                default:
                    OverRange();
                    break;
            }
        }
    }

    static void Start()
    {
        Render();
    }
    
   static void boolReverse (ref bool boo)
   {
       boo = !boo;
   }
    
    static void End()
    {
        Console.Clear();
        Console.Write("게임이 종료 되었습니다.");
        Environment.Exit(0);
    }

    static void Render()
    {
        int myClLv = 2;
        bool typeCH = false;
        Console.WriteLine("몇 단계로 시작하시겠습니까?");
        Console.WriteLine("1. 레벨 1(클리어)");
        Console.WriteLine("2. 레벨 2(클리어)");
        Console.WriteLine("3. 레벨 3");
        Console.WriteLine("4. 레벨 4(실행 불가)");
        Console.WriteLine("5. 레벨 5(실행 불가)");
        Console.WriteLine("0. 메인으로");
        
        while (!typeCH)
        {
            int z;
            typeCH = int.TryParse(Console.ReadLine(), out z);

            switch (z)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    
                    if (z > ++myClLv)
                    {
                        NoNextMap();
                    }
                    else
                    {
                        MapPrint(z);
                    }
                    break;
                case 0:
                    typeCH = true;
                    break;
                default:
                    OverRange();
                    break;
                
            }
        }
    }

    static void OverRange()
    {
        Console.WriteLine("범위를 벗어났습니다.");
    }
    
    
    static void NoNextMap()
    {
        Console.WriteLine("지금은 실행할 수 없는 맵 입니다.");
    }
    
    static bool MapLevelCheck(int mapLevel, int myClLv)
    {
        if (mapLevel > ++myClLv)
        {
            NoNextMap();
            return true;
        }

        return false;
    }
    
    static bool MapLevel(int level, int myClLv)
    {
        bool bol = MapLevelCheck(level, myClLv);

        
        if (bol)
        {
            MapPrint(level);
        }

        return bol;
    }

    static void MapPrint(int level)
    {
        Console.Clear();
        char[,] map;
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