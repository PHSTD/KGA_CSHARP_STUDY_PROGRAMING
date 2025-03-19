using System.Text;

namespace CodingTest
{
    class Program
    {
        static int Main()
        {
            StringBuilder sb = new StringBuilder();
            int i1 = int.Parse(Console.ReadLine());
            int i2= int.Parse(Console.ReadLine());

            Console.WriteLine(add(i1, i2));
            return 0;
        }
        
        static int add(int i1, int i2)
        {
            return i1 + i2;
        }
        
    }
}