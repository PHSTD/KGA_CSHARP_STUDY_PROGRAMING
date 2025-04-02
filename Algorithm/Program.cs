namespace Algorithm;

class Program
{
    static void Main(string[] args)
    {
        // 가장 큰 수를 찾기
        int[] array = { 1, 2, 3, 4, 5 };
        // 1. 가장 큰 수를 저장할 변수 만들기
        int max;
        // 2. 맨처음부터 시작
        int index = 0;
        // 3. 맨 처음부터 시작한 수가 다음 수보다 작으면 큰 수를 다음수로 변경
        // 3-1. 
        // 4. 다음 수를 또 다시 반복

        int result = Recursion.Factorial(5);
        Console.WriteLine(result);
    }
}