using System.Runtime.InteropServices.Marshalling;

namespace Algorithm;

public class Sorting
{
    // 선택정렬
    // 데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
    // 시간복잡도 - O(n^2)
    // 공간복잡도 - O(1)
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                // 가장 낮은 수를 찾으면 교체
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            
            Swap(array, i, minIndex);
        }
    }
    
    // 삽입 정렬
    public static void InsertionSort(int[] array)
    {
        // 처음부터 끝까지 반복
        for (int i = 0; i < array.Length; i++)
        {
            // 적합한 위치에 들어갈때 까지 반복
            for (int j = i; j > 0; j--)
            {
               // 다음 수자를 하나씩 꺼내서 
               if (array[j - 1] > array[j])
               {
                   // 앞 숫자와 비교해서 더 작으면 한칸 뒤로 밀고
                   Swap(array, j-1, j);
               }
               else
               {
                   // 작지 않으면 그 자리에 넣기
                   break;
               }
            }
           
        }
    }
    
    // <힙정렬>
    // 힙을 이용하여 우선순위가 가장 높은 요소가 가장 마지막 요소와 교체된 후 제거되는 방법을 이용
    // 배열에서 연속적인 데이터를 사용하지 않기 때문에 캐시 메모리를 효율적으로 사용할 수 없어 상대적으로 느림
    // 시간복잡도 -  O(nlogn)
    // 공간복잡도 -  O(1)
    // 안정정렬   -  X
    public static void HeapSort(int[] list)
    {
        MakeHeap(list);

        for (int i = list.Length- 1; i > 0; i--)
        {
            Swap(list, 0, i);
            Heapify(list, 0, i);
        }
    }

    private static void MakeHeap(int[] list)
    {
        for (int i = list.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(list, i, list.Length);
        }
    }

    private static void Heapify(int[] list, int index, int size)
    {
        int left = index * 2 + 1;
        int right = index * 2 + 2;
        int max = index;
        if (left < size && list[left] > list[max])
        {
            max = left;
        }
        if (right < size && list[right] > list[max])
        {
            max = right;
        }

        if (max != index)
        {
            Swap(list, index, max);
            Heapify(list, max, size);
        }
    } 
    
    
    // 퀵정렬
    public static void QuickSort(int[] array) => QuickSort(array, 0, array.Length - 1);

    public static void QuickSort(int[] array, int start, int end)
    {
        if (start >= end)
            return;
        int pivot = start;
        int left = pivot + 1;
        int right = end;

        // 레프트와 라이트가 교차할때 까지 반복
        while (left <= right)
        {
            // 레프트는 피벗보다 더 큰값을 볼때 까지 오른쪽으로 이동
            while (array[pivot] >= array[left] && left < right)
            {
                left++;
            }

            while (array[pivot] < array[right] && left <= right)
            {
                right--;
            }
            // 라이트는 피벗보다 더 작은값을 볼때까지 왼쪽으로 이동
            
            // 레프트와 라이트가 교차 안했다면
            if (left < right)
            {
               // 레프트와 라이트 값을 교체 
               Swap(array, left, right);
            }
            else
            {
                // pivot과 라이트를 r
               Swap(array, pivot, right);
               break;
            }
        }
        QuickSort(array, start, right - 1);
        QuickSort(array, right + 1, end);
    }
        
    
    // 병합정렬
    public static void MergeSort(int[] array) => MergeSort(array, 0, array.Length - 1);
    public static void MergeSort(int[] array, int start, int end)
    {
        // 1개만 남았을땐 돌아가게
        if (start == end)
        {
            return;
        }
        // 0 ~ 20
        int mid = (start + end) / 2;
        MergeSort(array, start, mid); // 0 ~ 10
        MergeSort(array, mid + 1, end); // 11 ~ 20
        Merge(array, start, mid, end);
    }

    public static void Merge(int[] array, int start, int mid, int end)
    {
        List<int> sortedList = new List<int>();
        int leftIndex = start;
        int rightIndex = mid + 1;

        // 한쪽이 모두 소진 될때까지
        while (leftIndex <= mid && rightIndex <= end)
        {
            // 왼쪽이 작으면
            if (array[leftIndex] < array[rightIndex])
            {
                // 왼쪽 값 정렬된 리스트에 집어넣기
                sortedList.Add(array[leftIndex]);
                leftIndex++;
            }
            else
            {
                // 오른쪽 값 정렬된 리스트에 집어넣기
                sortedList.Add(array[rightIndex]);
                rightIndex++;
            }
        }
        // 남아있는 것들을 정렬된 모드 추가
        // 왼쪽이 남아있으면
        if (leftIndex <= mid)
        {
            // 왼쪽 나머지들 모두 정렬된 리스트에 추가
            while (leftIndex <= mid)
            {
                sortedList.Add(array[leftIndex]);
                leftIndex++;
            }
        }
        // 오른쪽 나머지를 모두 정렬된 리스트에 추가
        else // if(rightIdex <= end)
        {
            // 왼쪽 나머지들 모두 정렬된 리스트에 추가
            while (rightIndex<= end)
            {
                sortedList.Add(array[rightIndex]);
                rightIndex++;
            }
        }

        for (int i = 0; i < sortedList.Count; i++)
        {
            array[start + i] = sortedList[i];
        }
    }
    
    // 버블정렬
    public static void BubbleSort(int[] array)
    {
        // 처음부터 끝까지 반복
        for(int i = 1; i < array.Length; i++)
        {
            // 하나씩 골라서 하는 작업 반복
            for (int j = 0; j < array.Length - 1; j++)
            {
                // 서로 인접한 두 데이터를 비교해서 더 크면
                if (array[j] > array[j + 1])
                {
                    Swap(array,j,j + 1);
                }
            }
        }
    }

    private static void Swap(int[] array, int left, int right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }
}