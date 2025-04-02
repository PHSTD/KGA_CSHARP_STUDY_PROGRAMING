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

    private static void Swap(int[] array, int left, int right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }
}