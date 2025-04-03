using System.Net.Mime;

namespace Algorithm.Searching;

public class Searching
{
    // 순차 탐색
    public static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
    
    // 이진탐색
    public static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        // 찾을때 까지 || 없을때까지
        while (low <= high)
        {
            int mid = (low + high) / 2;
            // 중간 위치를 mid로 잡는다;
            // 중간값이 찾고자하는 값보다 더 큰 경우
            if (array[mid] > target)
            {
                // 오른쪽 값들은 무시 -> high를 mid쪽으로 한칸 앞으로 옮긴다
                high = mid - 1;
            }
            // 중간값이 찾고자 하는 값보다 더 작은 경우
            else if (array[mid] < target)
            {
                // 왼쪽 값들은 무시 -> low를 mid쪽으로 한칸 뒤로 옮긴다
                low = mid + 1;
            }
            // 중간값이 찾고자하는 값이랑 같은 경우
            else
            {
                // 값을 찾았다.
                return mid;
            }
        }
        // 없다는 반황을 진행
        return -1;
    }
    
    // 너비 우선 탐색 (Breadth-First Search)
    public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
    {
        // 사전 세팅
        int size = graph.GetLength(0);
        visited = new bool[size];
        parents = new int[size];

        for (int i = 0; i < size; i++)
        {
            visited[i] = false;
            parents[i] = -1;
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;

        // 탐색 시작
        while (queue.Count > 0)
        {
            // 큐에서 다음으로 탐색할 정점을 확인한다;
            int next = queue.Dequeue();

            // 다음으로 탐색할 정점을 기준으로 탐색할 수 있는 정점들을 큐에 담는다.
            for (int vertext = 0 ; vertext < size ; vertext++)// 정점들을 반복하며
            {
                // 연결되어 있으면서 && 이미 찾은 정점이 아닌때
                if ( graph[next, vertext] == true && visited[vertext] == false )
                {
                    // 큐에 탐색할 수 있는 정점을 추가한다.
                    queue.Enqueue(vertext);
                    // 탐색할 수 있는 정점을 방문 표시.
                    visited[vertext] = true;
                    // 탐색할 수 있는 정점을 이전 정점을 표시한다;
                    parents[vertext] = next;
                }
            } 
            

        }
    }
    
    // <깊이 우선 탐색 (Depth-First Search)>

}