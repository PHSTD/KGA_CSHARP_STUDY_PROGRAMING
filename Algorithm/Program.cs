namespace Algorithm;

class Program
{
    static void Main(string[] args)
    {
        // 가장 큰 수를 찾기
        // int[] array = { 1, 2, 3, 4, 5 };
        // 1. 가장 큰 수를 저장할 변수 만들기
        // int max;
        // 2. 맨처음부터 시작
        // int index = 0;
        // 3. 맨 처음부터 시작한 수가 다음 수보다 작으면 큰 수를 다음수로 변경
        // 3-1. 
        // 4. 다음 수를 또 다시 반복

        // 재귀함수
        // int result = Recursion.Factorial(5);
        // Console.WriteLine(result);
        
        
        Random random = new Random();
        int count = 20;

        int[] selectArray = new int[count];
        int[] insertArray = new int[count];
        int[] bubbleArray = new int[count];
        Console.WriteLine("랜덤 데이터 결과 : ");
        for (int i = 0; i < count; i++)
        {
            int rand = random.Next(0, 100);
            Console.Write($"{rand, 3} ");
            
            selectArray[i] = rand;
            insertArray[i] = rand;
            bubbleArray[i] = rand;
        }
        Console.WriteLine();
        Console.WriteLine();
        
        Sorting.SelectionSort(selectArray);
        Console.WriteLine("선택 정렬 결과 : ");
        foreach (int value in selectArray)
        {
            Console.Write($"{value,3} ");
        }
        Console.WriteLine();
        
        
        Sorting.InsertionSort(insertArray);
        Console.WriteLine("삽입 정렬 결과 : ");
        foreach (int value in selectArray)
        {
            Console.Write($"{value,3} ");
        }
        Console.WriteLine();
        
        Sorting.BubbleSort(bubbleArray);
        Console.WriteLine("버블 정렬 결과 : ");
        foreach (int value in selectArray)
        {
            Console.Write($"{value,3} ");
        }
        Console.WriteLine();
    }
}