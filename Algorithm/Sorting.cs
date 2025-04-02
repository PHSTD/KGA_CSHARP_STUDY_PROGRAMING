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