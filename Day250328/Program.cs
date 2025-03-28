namespace Day250328;

class Program
{
    static void Main(string[] args)
    {
        // 과제
        Training training = new Training();
        
        int n = 8;
        int k = 5;
        int result = training.Yosepus(n, k);
        Console.WriteLine("요세푸스({0}, {1}) 의 결과는 : {2}", n, k, result);

        string str = "([])";
        Console.WriteLine("괄호 검사기의 결과는 : {0}", training.IsCorrectBracket(str));
    }
}