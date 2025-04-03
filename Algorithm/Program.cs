using System.Security.Cryptography.X509Certificates;

namespace Algorithm;

class Program
{
    static void Main(string[] args)
    {

        // 순차 탐색
        int[] array = { 0, 4, 5, 6, 7, 8, 2, 1 };
        int findIndex = Searching.Searching.LinearSearch(array, 2);
        Console.WriteLine($"탐색 결과 : {findIndex}");
        
        // 이진 탐색
        int[] arra1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int binIndex = Searching.Searching.BinarySearch(arra1, 6);
        Console.WriteLine($"탐색 결과 : {binIndex}");
        
        // 너비 우선 탐색 (Breadth-First Search) 
        bool[,] graph = new bool[8, 8];
        graph[0, 1] = true;
        graph[1, 0] = true;
        graph[0, 2] = true;
        graph[2, 0] = true;
        graph[0, 4] = true;
        graph[4, 0] = true;
        graph[1, 3] = true;
        graph[3, 1] = true;
        graph[1, 5] = true;
        graph[5, 1] = true;
        graph[2, 6] = true;
        graph[6, 2] = true;
        graph[4, 7] = true;
        graph[7, 4] = true;
        graph[5, 7] = true;
        graph[7, 5] = true;
        graph[6, 7] = true;
        graph[7, 6] = true;
        Searching.Searching.BFS(graph, 0, out bool[] visited, out int[] parents);
        Console.WriteLine($"{"Vertext",8}{"visited", 8}{"Parent", 8}");
        for (int i = 0; i < visited.Length; i++)
        {
            Console.WriteLine($"{i,8}{visited[i], 8}{parents[i], 8}");
        }


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


        // 정렬
        // Random random = new Random();
        // int count = 20;
        //
        // int[] selectArray = new int[count];
        // int[] insertArray = new int[count];
        // int[] bubbleArray = new int[count];
        // int[] mergeArray = new int[count];
        // int[] quickArray = new int[count];
        // int[] heapArray = new int[count];
        //
        // Console.WriteLine("랜덤 데이터 결과 : ");
        // for (int i = 0; i < count; i++)
        // {
        //     int rand = random.Next(0, 100);
        //     Console.Write($"{rand, 3} ");
        //     
        //     selectArray[i] = rand;
        //     insertArray[i] = rand;
        //     bubbleArray[i] = rand;
        //     mergeArray[i] = rand;
        //     quickArray[i] = rand;
        //     heapArray[i] = rand;
        // }
        // Console.WriteLine();
        // Console.WriteLine();
        //
        // Sorting.SelectionSort(selectArray);
        // Console.WriteLine("선택 정렬 결과 : ");
        // foreach (int value in selectArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();
        //
        //
        // Sorting.InsertionSort(insertArray);
        // Console.WriteLine("삽입 정렬 결과 : ");
        // foreach (int value in selectArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();
        //
        // Sorting.BubbleSort(bubbleArray);
        // Console.WriteLine("버블 정렬 결과 : ");
        // foreach (int value in selectArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();
        //
        //
        //
        // Sorting.MergeSort(mergeArray);
        // Console.WriteLine("병합 정렬 결과 : ");
        // foreach (int value in mergeArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();
        //
        //
        //
        // Sorting.QuickSort(quickArray);
        // Console.WriteLine("퀵 정렬 결과 : ");
        // foreach (int value in quickArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();
        //
        //
        // Sorting.HeapSort(heapArray);
        // Console.WriteLine("힙 정렬 결과 : ");
        // foreach (int value in heapArray)
        // {
        //     Console.Write($"{value,3} ");
        // }
        // Console.WriteLine();

    }
    
    
    
}