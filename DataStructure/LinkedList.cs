namespace DataStructure;

public class LinkedList
{
     /**********************************************************************************
     * 연결리스트 (Linked List)
     * 
     * 데이터를 포함하는 노드들을 연결식으로 만든 자료구조
     * 데이터와 다른 데이터 지점의 참조변수를 가진 노드를 기본 단위로 사용
     * 데이터를 노드를 통해 연결식으로 구성하기 때문에 데이터의 추가/삭제에 유용
     * 노드가 메모리에 연속적으로 배치되지 않고 연결 구조로 다른 데이터의 위치를 확인(index 사용 불가)
     ***********************************************************************************/

    // <연결리스트 구현>
    // 연결리스트는 노드를 기본 단위로 연결식으로 구현
    // 노드간의 연결구조에 따라 단방향, 양방향, 원형 으로 구분
    //
    // 1. 단방향 연결리스트
    // 노드가 다음 노드를 참조
    // ┌────┬─┐  ┌────┬─┐  ┌────┬─┐  ┌────┬─┐
    // │Data│───→│Data│───→│Data│───→│Data│ │
    // └────┴─┘  └────┴─┘  └────┴─┘  └────┴─┘
    //
    // 2. 양방향 연결리스트
    // 노드가 이전/다음 노드를 참조
    // ┌─┬────┬─┐  ┌─┬────┬─┐  ┌─┬────┬─┐  ┌─┬────┬─┐
    // │ │Data│←────→│Data│←────→│Data│←────→│Data│ │
    // └─┴────┴─┘  └─┴────┴─┘  └─┴────┴─┘  └─┴────┴─┘
    //
    // 3. 원형 연결리스트
    // 노드가 이전/다음 노드를 참조하며, 시작 노드와 마지막 노드를 참조
    //  ┌──────────────────────────────────────────┐
    // ┌│┬────┬─┐  ┌─┬────┬─┐  ┌─┬────┬─┐  ┌─┬────┬│┐
    // │↓│Data│←────→│Data│←────→│Data│←────→│Data│↓│
    // └─┴────┴─┘  └─┴────┴─┘  └─┴────┴─┘  └─┴────┴─┘


    // <연결리스트 삽입>
    // 새로 추가하는 노드가 이전/이후 노드를 참조한 뒤
    // 이전/이후 노드가 새로 추가하는 노드를 참조함
    // 
    //          ┌─┬───┬─┐                      ┌─┬───┬─┐                      ┌─┬───┬─┐ 
    //          │ │ C │ │                    ┌───│ C │───┐                  ┌───│ C │───┐
    //          └─┴───┴─┘          =>        ↓ └─┴───┴─┘ ↓        =>        ↓ └─┴───┴─┘ ↓
    // ┌─┬───┬─┐         ┌─┬───┬─┐    ┌─┬───┬─┐         ┌─┬───┬─┐    ┌─┬───┬─┐ ↑     ↑ ┌─┬───┬─┐
    // │ │ A │←───────────→│ B │ │    │ │ A │←───────────→│ B │ │    │ │ A │───┘     └───│ B │ │
    // └─┴───┴─┘         └─┴───┴─┘    └─┴───┴─┘         └─┴───┴─┘    └─┴───┴─┘         └─┴───┴─┘


    // <연결리스트 삭제>
    // 삭제하는 노드의 이전 노드가 이후 노드를 참조한 뒤
    // 삭제하는 노드의 이후 노드가 이전 노드를 참조함
    // 
    //          ┌─┬───┬─┐                      ┌─┬───┬─┐                      ┌─┬───┬─┐
    //        ┌──→│ C │←──┐                    │ │ C │←──┐                    │ │ C │ │
    //        │ └─┴───┴─┘ │        =>          └─┴───┴─┘ │        =>          └─┴───┴─┘
    // ┌─┬───┬│┐         ┌│┬───┬─┐    ┌─┬───┬─┐         ┌│┬───┬─┐    ┌─┬───┬─┐         ┌─┬───┬─┐
    // │ │ A │↓│         │↓│ B │ │    │ │ A │──────────→│↓│ B │ │    │ │ A │←───────────→│ B │ │
    // └─┴───┴─┘         └─┴───┴─┘    └─┴───┴─┘         └─┴───┴─┘    └─┴───┴─┘         └─┴───┴─┘


    // <연결리스트 특징>
    // 연결리스트의 경우 데이터를 연속적으로 배치하는 배열과 다르게 연결식으로 구성
    // 따라서, 데이터의 추가/삭제 과정에서 다른 데이터의 위치와 무관하게 진행되므로 수월함(밀거나 당기거나하는 기능을 안함)
    // 하지만, 데이터의 접근 과정에서 연속적인 데이터 배치가 아니기 때문에 인덱스 사용 불가하여 처음부터 탐색해야 함
    // 따로따로 저장하기 때문에 용량이 필요 없다


    // <LinkedList의 시간복잡도>
    // 접근    탐색    삽입    삭제
    // O(n)    O(n)    O(1)    O(1)
    public void LinkedListTest()
    {
        LinkedList<string> linkedList = new LinkedList<string>();
        
        // 추가
        LinkedListNode<string> node0 = linkedList.AddFirst("0 데이터"); // 앞에 붙이기
        LinkedListNode<string> node1 = linkedList.AddLast("1 데이터"); // 뒤에 붙이기
        LinkedListNode<string> node2 = linkedList.AddLast("2 데이터");
        LinkedListNode<string> node3 = linkedList.AddLast("3 데이터");
        LinkedListNode<string> node4 = linkedList.AddBefore(node1, "4 데이터");
        LinkedListNode<string> node5 = linkedList.AddAfter(node1, "5 데이터");
        
        // 삭제
        linkedList.Remove(node1); // O(1)
        linkedList.RemoveFirst(); // O(1)
        linkedList.RemoveLast(); // O(1)
        linkedList.Remove("1 데이터"); // O(n) 찾아서 지워야하기 때문에
        
        // 접근
        // linkedList[2] : 연결리스트는 인덱스가 없다(연속적으로 저장하지 않기 때문에 인덱스 사용이 불가능하다)
        LinkedListNode<string> prevNode = node1.Previous;
        LinkedListNode<string> nextNode = node1.Next;
        LinkedListNode<string> firstNode = linkedList.First;
        LinkedListNode<string> lastNode = linkedList.Last;
        // c#에서 양방향이기 때문에 first last를 지원한다
        
        // 탐색
        LinkedListNode<string> findNode = linkedList.Find("1 데이터");
        bool Contain = linkedList.Contains("1 데이터");
        
        Console.WriteLine(node1.Value);
        Console.WriteLine(node1.Next.Value);
        Console.WriteLine(node1.Previous.Value);
        
        
        // foreach 반복문이 있는 이유
        int[] array = new int[8];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        foreach (int value in array)
        {
            
        }

        LinkedList<int> list = new LinkedList<int>();
        // for (int i = 0; i < array.Length; i++)
        // {
            // Console.WriteLine(list[i]);//  반복이 불가하다 (인덱스가 없기 때문에)
        // }
        // 이런식으로 찾아야함
        // for (LinkedListNode<int> node = list.First; node != null; node = node.Next)
        // {
            // Console.WriteLine(node.Value);
        // }
        // 처음부터 끝까지 반복한다
        foreach (int node in list)
        {
            Console.WriteLine(node);
        }
    }
    
}