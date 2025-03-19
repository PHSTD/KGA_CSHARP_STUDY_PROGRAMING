namespace Day250313_3;

class Program
{
    static void Main(string[] args)
    {
        string space = " ";
        string star = "*";
        
        #region 심화다이아 
        Console.WriteLine("심화다이아");
        int dia = 5;
        for (int i = 0; i < dia; i++)
        {
            for (int j = 0; j < dia - i - 1; j++)
            {
                Console.Write(space);
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(star);
                Console.Write(space);
            }
            Console.WriteLine();
        }
        
        for (int i = dia - 2; i >= 0; i--)
        {
            for (int j = 0; j < dia - i - 1; j++)
            {
                Console.Write(space);
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(star);
                Console.Write(space);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
