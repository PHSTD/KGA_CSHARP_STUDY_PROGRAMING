namespace Day250331;

public class Team
{
    private bool[,] metrix = new bool[8, 8]
    {    // 0     1      2       3       4      5     6      7
        { false, true, false,  false,  true,  false, false, false}, // 0
        { true,  false, true,  false,  false, false, true, false}, // 1
        { true,  true,  false, false,  false, true, true,  false}, // 2
        { false, false, false, false,  false, true,  false, false}, // 3
        { false, false, false, false,  false, false, false, false}, // 4
        { false, false, false, true,  false,  false, true,  false}, // 5
        { false, false, true, false, true,   false, false, true}, // 6
        { false, false, false, false, false,  true,  true,  false} // 7
    };

    public Team()
    {
        // Console.WriteLine(metrix[0,0]);
        for (int i = 0; i < metrix.GetLength(0); i++)
        {
            for (int j = 0; j < metrix.GetLength(1); j++)
            {
                // Console.WriteLine("  0  1  2  3  4  5  6  7  8");
                if(metrix[i, j] == false)
                {
                    Console.Write($"{metrix[i, j]} ");
                }
                else
                {
                    Console.Write($"{metrix[i, j]}  ");
                }
            }
            Console.WriteLine();
        }
    }
}