namespace _05.Debugger;

class Program
{
    static void Main(string[] args)
    {
        //  // 과제 1
        // Console.Write("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요 : ");
        // // int int1 = int.Parse(Console.ReadLine());
        // int int1 = 1;
        // Console.Write("끝 수를 입력하여주세요 : ");
        // // int int2 = int.Parse(Console.ReadLine());
        // int int2 = 2;
        // int total = 0;
        //
        // if (int1 >= int2)
        // {
        //     Console.WriteLine("첫번째 값이 두번째 값보다 크거나 같을 수 없습니다.");
        // }
        // else
        // {
        //     for (int i = int1; i <= int2; i++)
        //     {
        //         total += i;
        //     }
        //     Console.WriteLine("{0}과 {1} 사이 숫자의 합은 {2}입니다.", int1, int2, total);
        // }
        
        // 과제 4
        string space = " ";
        string star = "*";
        
        // #region 과제4-1
        // Console.Write("4 - 1 : ");
        // Console.WriteLine();
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j <= i; j++)
        //     {
        //         Console.Write(star);
        //         Console.Write(space);
        //     }
        //     Console.WriteLine();
        // }
        // #endregion 과제4-1
        
        #region 과제 4-2
        Console.Write("4 - 2 : ");
        Console.WriteLine();
        for (int i = 5; i > 0; i--)
        {
            for (int j = 5; j > i - 1; j--)
            {
                for (int z = 10; z > i-1; z--)
                {
                    // if (z != i)
                    // {
                        Console.Write(space);
                }
                Console.Write(star);
                Console.Write(space);
            }
            Console.WriteLine();
        }
        #endregion
        
        // #region 과제4-3
        // Console.Write("4 - 3 : ");
        // Console.WriteLine();
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 5; j > i; j--)
        //     {
        //         Console.Write(star);
        //         Console.Write(space);
        //     }
        //     Console.WriteLine();
        // }
        // #endregion
        
        // #region 과제 4-4
        // Console.Write("4 - 4 : ");
        // Console.WriteLine();
        // int n = 5;
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < i; j++)
        //     {
        //         Console.Write(space);
        //     }
        //     for (int j = 0; j < n - i; j++)
        //     {
        //         Console.Write(star);
        //         Console.Write(space);
        //     }
        //     Console.WriteLine();
        // }
        // #endregion
        
    }
}