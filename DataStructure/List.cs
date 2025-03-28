namespace DataStructure;

public class List
{
         /*******************************************************
         * 리스트 (List)
         * 
         * 런타임 중 크기를 확장할 수 있는 배열기반의 자료구조
         * 배열요소의 갯수를 특정할 수 없는 경우 사용이 용이
         *******************************************************/

        // <리스트 구현>
        // 리스트는 배열기반의 자료구조이며, 배열은 크기를 변경할 수 없는 자료구조
        // 리스트는 동작 중 크기를 확장하기 위해 포함한 데이터보다 더욱 큰 배열을 사용
        //
        // 크기 = 3, 용량 = 8       크기 = 4, 용량 = 8       크기 = 5, 용량 = 8
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│ │ │ │ │ │        │1│2│3│4│ │ │ │ │        │1│2│3│4│5│ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘


        // <리스트 삽입>
        // 중간에 데이터를 추가하기 위해 이후 데이터들을 뒤로 밀어내고 삽입 진행
        //      ↓                        ↓                        ↓
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│ │ │ │ │   =>   │1│2│ │3│4│ │ │ │   =>   │1│2│A│3│4│ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘


        // <리스트 삭제>
        // 중간에 데이터를 삭제한 뒤 빈자리를 채우기 위해 이후 데이터들을 앞으로 당김
        //      ↓                        ↓
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐        ┌─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│A│3│4│ │ │ │   =>   │1│2│ │3│4│ │ │ │   =>   │1│2│3│4│ │ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘        └─┴─┴─┴─┴─┴─┴─┴─┘


        // <리스트 용량>
        // 용량을 가득 채운 상황에서 데이터를 추가하는 경우
        // 더 큰 용량의 배열을 새로 생성한 뒤 데이터를 복사하여 새로운 배열을 사용
        //
        // 1. 리스트가 가득찬 상황에서 새로운 데이터 추가 시도
        // 크기 = 8, 용량 = 8
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│5│6│7│8│ ← A 추가
        // └─┴─┴─┴─┴─┴─┴─┴─┘
        //
        // 2. 새로운 더 큰 배열 생성
        // 크기 = 8, 용량 = 8          크기 = 0, 용량 = 16
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐           ┌─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│5│6│7│8│ ← A 추가   │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┘           └─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┘
        //
        // 3. 새로운 배열에 기존의 데이터 복사
        // 크기 = 8, 용량 = 8          크기 = 8, 용량 = 16
        // ┌─┬─┬─┬─┬─┬─┬─┬─┐          ┌─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│5│6│7│8│ ← A 추가  │1│2│3│4│5│6│7│8│ │ │ │ │ │ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┘          └─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┘
        //
        // 4. 기본 배열 대신 새로운 배열을 사용
        // 크기 = 8, 용량 = 16
        // ┌─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│5│6│7│8│ │ │ │ │ │ │ │ │ ← A 추가
        // └─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┘
        //
        // 5. 빈공간에 데이터 추가
        // 크기 = 9, 용량 = 16
        // ┌─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┬─┐
        // │1│2│3│4│5│6│7│8│A│ │ │ │ │ │ │ │
        // └─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┴─┘


        // <리스트 시간복잡도>
        // 접근    탐색    삽입    삭제
        // O(1)    O(n)    O(n)    O(n) 

        public void ListTest()
        {
            int[] array = new int[4];
            
            List<int> list = new List<int>(1200); // 1000개가 넘어가는거면 미리 지정해주면 늘려주는 과정이 없어지면서 더욱 효율이 좋아진다
            // list.Capacity = 1200;
            for (int i = 0; i < 2000; i++)
            {
                list.Add(i);
                Console.WriteLine("Count = {0}, Capacity = {1}", list.Count, list.Capacity);
            }

            return ;

            // 추가
            list.Add(1); // 맨뒤에 추가 : O(1)
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Insert(2,999); // 중간에 끼워넣기 : O(n) "O(n)이정도면 빠른거"


            // 삭제
            list.Remove(999); // 똑같은거 찾아서 삭제하기(여러개일 경우 제일 첫번째꺼 삭제함) : O(n)
            list.RemoveAt(1); // 몇번째꺼 지우기(인덱스 위치 요소 삭제) 크기를 벗어나면 에러난다 : O(n)
            list.Remove(55); // 찾아서 지울때 없으면 무시(반화은 false)

            // 접근 : O(1)
            list[1] = 222; // 리스트는 배열로 구현되어 있기 때문에 인덱스를 통한 접근이 가능하다
            int value = list[1];

            // 탐색 : O(n)
            int index = list.IndexOf(222); // 찾아서 인덱스 가져오기
            bool contain = list.Contains(222); // 찾아서 있으면 true, 없으면 false


            int count = list.Count; // 리스트에 소유중인 갯수
            int capacity = list.Capacity; // 총 크기

        }
        
    public class MyList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }

        public int Capacity { get { return items.Length; } }
        public int Count { get { return count; } }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Grow();
            }

            items[count] = item;
            count++;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || count < index)
                throw new ArgumentOutOfRangeException();

            if (index == count)
            {
                Add(item);
                return;
            }

            if (count == items.Length)
            {
                Grow();
            }
            
            Array.Copy(items, index, items, index + 1, count - index);
            items[index] = item;
            count++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || count <= index)
                throw new IndexOutOfRangeException();

            count--;
            Array.Copy(items, index + 1, items, index, count - index);
        }

        public int IndexOf(T item)
        {
            if (item != null)
            {
                for (int i = 0; i < count; i++)
                {
                    if (item.Equals(items[i]))
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (null == items[i])
                    {
                        return i;
                    }
                }
            }
            
            return -1;
        }

        public void Clear()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }

        private void Grow()
        {
            T[] newItems = new T[items.Length * 2];
            Array.Copy(items, 0, newItems, 0, count);
            items = newItems;
        }
    }
}