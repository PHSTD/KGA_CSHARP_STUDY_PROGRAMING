using System.ComponentModel.Design;
namespace Day250318_1;


class Program
{

    struct Position
    {
        public int x;
        public int y;
    }

    static void Main(string[] args)
    {
        bool gameOver = false;
        Position playerPos;
        Position goalPos;
        bool[,] map;


        //게임 준비

        Start(out playerPos,out goalPos, out map);
        while(gameOver == false)
        {
            
            Render(playerPos, goalPos ,map);
            ConsoleKey key = Input();
            Update(key,ref playerPos,goalPos,map,ref gameOver);
        }
        //게임 종료
        End();
        
    }
   
    //시작작업
    static void Start(out Position playerPos,out Position goalPos ,out bool[,] map)
    {
        //게임 설정
        Console.CursorVisible = false;
        //플레이어 초기 위치 설정하기
        playerPos.x = 1;
        playerPos.y = 1;

        //목적지 위치 설정하기
        goalPos.x = 8;
        goalPos.y = 8;

        //맵 설정하기
        map = new bool[10, 15]
        {
            //0      1       2       3       4       5       6       7       8       9       10      11      12      13      14
        /*0*/{false, false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false},
        /*1*/{false, true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*2*/{false, true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*3*/{false, true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*4*/{false, true,   false,  true,   true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*5*/{false, true,   false,  true,   true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*6*/{false, true,   false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*7*/{false, true,   false,  false,  false,  true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*8*/{false, true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   true,   false},
        /*9*/{false, false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false,  false}
        };
        ShowTitle();
    }
    static void ShowTitle()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("레전드 미로찾기");
        Console.WriteLine("---------------------");
        Console.WriteLine("");
        Console.WriteLine("아무키나 눌러서 시작하세요...");

        Console.ReadKey(true);
        Console.Clear();
    }
    //출력작업
    static void Render(Position playerPos,Position goalPos,bool[,] map)
    {
        //콘솔 지우기
        //Console.Clear();
        //덮어 그리기
        Console.SetCursorPosition(0,0);
        PrintMap(map);
        PrintPlayer(playerPos);
        PrintGoal(goalPos);

    }
    static void PrintMap(bool[,] map)
    {
        //맵 출력
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                if (map[y, x] == false)
                {
                    Console.Write('#');//벽
                }
                else
                {
                    Console.Write(' ');//빈공간
                }

            }
            Console.WriteLine();
        }
    }
    static void PrintPlayer(Position playerPos)
    {
        //플레이어 위치로 커서옮기기
        Console.SetCursorPosition(playerPos.x, playerPos.y);
        //플레이어 출력
        Console.ForegroundColor = ConsoleColor.Green;//플레이어 색 변경
        Console.Write('P');
        Console.ResetColor();
    }
    static void PrintGoal(Position goalPos)
    {
        Console.SetCursorPosition(goalPos.x,goalPos.y);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write('G');
        Console.ResetColor();
    }
    //입력작업
    static ConsoleKey Input()
    {   
        ConsoleKey input = Console.ReadKey(true).Key;
        return input;
    }
    //처리작업
    static void Update(ConsoleKey key, ref Position playerPos,Position goalPos ,bool[,] map,ref bool gameOver)
    {
        Move(key, ref playerPos, map);
        //골에 도달했는지 확인
        bool isClear = CheckGameClear(playerPos, goalPos);
        if (isClear)
        {
            //게임 종료
            gameOver = true;
        }

    }
    static void Move(ConsoleKey key, ref Position playerPos, bool[,] map)
    {
        //이동
        switch (key)
        {
            case ConsoleKey.A:
            case ConsoleKey.LeftArrow:
                //이동하기 전 벽이 있는지 확인해서 벽이 아니면 움직이게
                if (map[playerPos.y, playerPos.x - 1] == true)
                {
                    playerPos.x--;
                }
                break;
            case ConsoleKey.D:
            case ConsoleKey.RightArrow:
                //이동하기 전 벽이 있는지 확인해서 벽이 아니면 움직이게
                if (map[playerPos.y, playerPos.x + 1] == true)
                {
                    playerPos.x++;
                }
                break;
            case ConsoleKey.W:
            case ConsoleKey.UpArrow:
                if (map[playerPos.y - 1, playerPos.x] == true)
                {
                    playerPos.y--;
                }
                break;
            case ConsoleKey.S:
            case ConsoleKey.DownArrow:
                if (map[playerPos.y + 1, playerPos.x] == true)
                {
                    playerPos.y++;
                }
                break;
        }
    }
        
    static bool CheckGameClear(Position playerPos, Position goalPos)
    {
        //플레이어가 골 위치에 도달했을 때
        //플레이어의 x위치가 골 x위치랑 같으면서 동시에
        //플레이어의 y위치가 골 y위치랑 같으면
        bool success = (playerPos.x == goalPos.x) && (playerPos.y == goalPos.y);
        return success;

        //게임은 클리어 되었다 라고 판정
    }
    //종료 작업
    static void End()
    {

    }
}