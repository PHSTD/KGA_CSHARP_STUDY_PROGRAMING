namespace Day250331;

public class Training
{
    private Dictionary<int, List<(int neighbor, double weight)>> adjacencyList;

    public Training()
    {
        adjacencyList = new Dictionary<int, List<(int, double)>>();
    }

    public void AddEdge(int from, int to, double weight)
    {
        if (weight < 0)
        {
            throw new ArgumentException("가중치는 음수가 될 수 없습니다.");
        }

        if (!adjacencyList.ContainsKey(from))
        {
            adjacencyList[from] = new List<(int, double)>();
        }

        adjacencyList[from].Add((to, weight));
    }

    public void PrintGraph()
    {
        foreach (var node in adjacencyList)
        {
            Console.Write($"노드 {node.Key} : ");
            foreach (var edge in node.Value)
            {
                Console.Write($" - 노드 {edge.neighbor}, 가중치: {edge.weight} ");
            }
            Console.WriteLine();
        }
    }
}