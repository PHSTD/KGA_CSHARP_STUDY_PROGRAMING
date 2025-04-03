using System.Security.Cryptography.X509Certificates;

namespace Algorithm.Searching;

public class PathfindingAlgorithms
{
    private const int INF = 99999;
    // 다익스트라 알고리즘
    public static void Dijkstra(int[,] graph, int start, out bool[] visited, out int[] parents, out int[] cost)
    {
        int size = graph.GetLength(0);
        visited = new bool[size];
        parents = new int[size];
        cost = new int[size];

        // 초기값
        for (int i = 0; i < size; i++)
        {
            visited[i] = false;
            parents[i] = -1;
            cost[i] = INF;
        }

        // 시작값
        cost[start] = 0;

        for (int i = 0; i < size; i++)
        {
            // 1.방문하지 않은 정정 중 가장 가까운 정접 선택
            int minIndex = -1;
            int minCost = INF;
            // 제일 작은거 찾아줘
            for (int j = 0; j < size; j++)
            {
                //     방문한적 없으며      &&   가장 가까운 정점
                if (visited[j] == false && cost[j] < minCost)
                {
                    // 찾으면 바꿔줘
                    minIndex = j;
                    minCost = cost[j];
                }
            }
            if (minIndex < 0)
            {
                break;
            }
            // 탐색시작
            visited[minIndex] = true;

            // 2. 직접 연결된 거리보다 거쳐서 더 짧아지면 대체
            for (int j = 0; j < size; j++)
            {
                // cost[j]              : 목적지까지 직접 연결된 거리 (AB)
                // cost[minIndex]       : 중간점까지의 직접 연결된 거리 (AC)
                // graph[minIndex, j]   : 중간점부터 목적지까지 거리 (CB)
                // 더해서 더 큰 경우 대체 한다
                if (cost[j] > cost[minIndex] + graph[minIndex, j])
                {
                    cost[j] = cost[minIndex] + graph[minIndex, j];
                    parents[j] = minIndex;
                }
            }
        }
    }
}