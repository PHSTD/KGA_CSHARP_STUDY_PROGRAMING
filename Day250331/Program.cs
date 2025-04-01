namespace Day250331;

class Program
{
    static void Main(string[] args)
    {
        // Training - 가중치 그래프 양방향
        Training traning = new Training();

        // 간선추가 그래프 이미지대로
        traning.AddEdge(0, 3, 5);
        traning.AddEdge(0, 4, 4);
        traning.AddEdge(1, 2, 8);
        traning.AddEdge(1, 5, 8);
        traning.AddEdge(1, 6, 8);
        traning.AddEdge(2, 1, 8);
        traning.AddEdge(2, 6, 9);
        traning.AddEdge(2, 5, 4);
        traning.AddEdge(2, 4, 4);
        traning.AddEdge(3, 0, 5);
        traning.AddEdge(4, 2, 4);
        traning.AddEdge(4, 0, 4);
        traning.AddEdge(5, 1, 8);
        traning.AddEdge(5, 2, 4);
        traning.AddEdge(5, 6, 9);
        traning.AddEdge(5, 7, 1);
        traning.AddEdge(6, 7, 6);
        traning.AddEdge(6, 5, 9);
        traning.AddEdge(6, 1, 8);
        traning.AddEdge(6, 2, 9);
        traning.AddEdge(7, 5, 1);
        traning.AddEdge(7, 6, 6);

        traning.PrintGraph();
        
        // Team
        // Team team = new Team();
    }
}
