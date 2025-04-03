namespace Algorithm.Searching;

public class Searching
{
    // 순차 탐색
    // 자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
    // 시간 복잡도 - O(n)
    public static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

}