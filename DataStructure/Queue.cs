namespace DataStructure;

public class Queue
{
    
    /******************************************************
     * 큐 (Queue)
     * 
     * 선입선출(FIFO), 후입후출(LILO) 방식의 자료구조
     * 입력된 순서대로 처리해야 하는 상황에 이용
     ******************************************************/

    // <큐 구현>
    // 1. 배열 사용
    // 선입선출(FIFO), 후입후출(LILO) 을 구현하기 위해 배열을 생성하고 순차적으로 데이터를 배치
    //     ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //   앞 │1│2│3│4│5│ │ │ │  뒤
    //     └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 삽입 -
    // 비어있는 가장 뒷쪽에 데이터를 배치
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │1│2│3│4│5│ │ │ │   =>   │1│2│3│4│5│6│ │ │
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 삭제 -
    // 가장 앞쪽 데이터를 출력하고 빈자리를 채우기 위해 나머지 데이터를 앞당기기 진행
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │1│2│3│4│5│6│ │ │   =>   │2│3│4│5│6│ │ │ │
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 문제발생 -
    // 큐의 삭제 과정시 나머지 데이터를 앞당겨야하는 N번의 작업 발생
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │1│2│3│4│5│6│ │ │   =>   │ │2│3│4│5│6│ │ │   =>   │2│3│4│5│6│ │ │ │
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘

    // 2. 전단 & 후단
    // 삽입 & 삭제 시 데이터를 앞당기지 않고 head와 tail을 표시하여 삽입할 위치와 삭제할 위치를 지정
    //
    // - 삽입 -
    // tail 위치에 데이터를 추가하고 tail을 한칸 뒤로 이동
    //     h       t                h         t
    //     ↓       ↓                ↓         ↓      
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │ │2│3│4│5│ │ │ │   =>   │ │2│3│4│5│6│ │ │
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 삭제 -
    // head 위치에 데이터를 추가하고 head을 한칸 뒤로 이동
    //     h         t                h       t
    //     ↓         ↓                ↓       ↓
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │ │2│3│4│5│6│ │ │   =>   │ │ │3│4│5│6│ │ │
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 문제발생 -
    // 큐의 배열 마지막 위치까지 사용하는 경우 빈자리가 없어 저장 불가한 상황 발생
    //       h         t              h           t
    //       ↓         ↓              ↓           ↓
    //  ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    //  │ │ │3│4│5│6│7│ │   =>   │ │ │3│4│5│6│7│8│
    //  └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘

    // 3. 순환배열
    // 배열의 끝까지 도달하여 빈자리가 없을 경우 처음으로 돌아가서 빈공간을 활용
    //
    // - 마지막위치 도달시 -
    // 다시 가장 앞 위치를 사용하여 빈공간을 재활용
    //          h     t          t       h           
    //          ↓     ↓          ↓       ↓           
    // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    // │ │ │ │ │5│6│7│ │   =>   │ │ │ │ │5│6│7│8│
    // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //
    // - 문제발생 -
    // tail이 head을 침범하는 경우 모든 공간이 비어있는 상황과 가득차 있는 상황을 구분할 수 없음
    // 
    //         th                       th       
    //         ↓↓                       ↓↓       
    // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    // │ │ │ │ │ │ │ │ │        │5│6│7│8│1│2│3│4│
    // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //   비어있는 경우             가득찬 경우

    // 4. 포화상태확인
    // head와 tail이 일치하는 경우를 비어있는 경우로 판정
    // tail이 head 전위치에 있는 경우를 실제로는 한자리가 비어있지만 가득찬 경우로 판정
    // 더 추가가 되면 배열을 더 늘려준다
    //         th                      t h       
    //         ↓↓                      ↓ ↓       
    // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
    // │ │ │ │ │ │ │ │ │        │5│6│7│ │1│2│3│4│
    // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘
    //   비어있는 경우         가득찬 경우(로 판정)
    
    public void Queues()
    {
        Queue<int> queue = new Queue<int>();
        
        // 추가 : O(1), 최악(용량이 가득 찼었을 때 : O(n) -> 더큰 배열을 만들고 n개를 더 복사해야해서
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        
        // 꺼내기 : O(1)
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        
        // 꺼내지 않고 확인(다음 차례 누구?) : O(1)
        Console.WriteLine(queue.Peek());
        
        // 추가 : O(1), 최악(용량이 가득 찼었을 때 : O(n) -> 더큰 배열을 만들고 n개를 더 복사해야해서
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        queue.Enqueue(9);

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        
    }

    public class MyQueue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;
        private int head;
        private int tail;

        public MyQueue()
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
        }

        public int Count
        {
            get
            {
                if (head <= tail)
                {
                    return tail - head;
                }
                else
                {
                    return tail + (array.Length - head);
                }
            }
        }

        public void Clear()
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Grow();
            }

            array[tail] = item;
            MoveNext(ref tail);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            T result = array[head];
            MoveNext(ref head);
            return result;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[head];
        }

        private void Grow()
        {
            int newCapacity = array.Length * 2;
            T[] newArray = new T[newCapacity];
            if (head < tail)
            {
                Array.Copy(array, head, newArray, 0, tail);
            }
            else
            {
                Array.Copy(array, head, newArray, 0, array.Length - head);
                Array.Copy(array, 0, newArray, array.Length - head, tail);
            }

            array = newArray;
            tail = Count;
            head = 0;
        }

        private bool IsFull()
        {
            if (head > tail)
            {
                return head == tail + 1;
            }
            else
            {
                return head == 0 && tail == array.Length - 1;
            }
        }

        private bool IsEmpty()
        {
            return head == tail;
        }

        private void MoveNext(ref int index)
        {
            index = (index + 1) % array.Length;
        }
    }
}