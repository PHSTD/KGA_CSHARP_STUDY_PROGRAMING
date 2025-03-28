namespace DataStructure;

public class Stack
{
    /******************************************************
     * 스택 (Stack)
     *
     * 선입후출(FILO), 후입선출(LIFO) 방식의 자료구조
     * 가장 최신 입력된 순서대로 처리해야 하는 상황에 이용
     ******************************************************/

    // <스택 구현>
    // 스택은 리스트를 사용법만 달리하여 구현 가능
    //
    // - 삽입 -
    //         top                      top
    //          ↓                        ↓
    // ┌─┬─┬─┬─┬─┬─┬─┬─┐      ┌─┬─┬─┬─┬─┬─┬─┬─┐
    // │1│2│3│4│5│ │ │ │  =>  │1│2│3│4│5│6│ │ │
    // └─┴─┴─┴─┴─┴─┴─┴─┘      └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 삭제 -
    //           top                  top
    //            ↓                    ↓
    // ┌─┬─┬─┬─┬─┬─┬─┬─┐      ┌─┬─┬─┬─┬─┬─┬─┬─┐
    // │1│2│3│4│5│6│ │ │  =>  │1│2│3│4│5│ │ │ │
    // └─┴─┴─┴─┴─┴─┴─┴─┘      └─┴─┴─┴─┴─┴─┴─┴─┘

    class MyStack<T>
    {
        private List<T> list = new List<T>();

        public int Count => list.Count;

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            T result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
        
        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException();

            return list[list.Count - 1];
        }
        
    }
    
    public void Stacks()
    {
        Stack<int> stack = new Stack<int>(20);
        
        // 추가 : O(1), 최악(용량이 가득 찼었을 때 : O(n) -> 더큰 배열을 만들고 n개를 더 복사해야해서
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        
        // 꺼내기 : O(1)
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        
        // 다음으로 꺼내질 요소 확인 : O(1)
        Console.WriteLine(stack.Peek());
        
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}