namespace Algorithm.Searching;

public class Searching
{
    // 순차 탐색
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
    
    // 이진탐색
    public static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        // 찾을때 까지 || 없을때까지
        while (low <= high)
        {
            int mid = (low + high) / 2;
            // 중간 위치를 mid로 잡는다;
            // 중간값이 찾고자하는 값보다 더 큰 경우
            if (array[mid] > target)
            {
                // 오른쪽 값들은 무시 -> high를 mid쪽으로 한칸 앞으로 옮긴다
                high = mid - 1;
            }
            // 중간값이 찾고자 하는 값보다 더 작은 경우
            else if (array[mid] < target)
            {
                // 왼쪽 값들은 무시 -> low를 mid쪽으로 한칸 뒤로 옮긴다
                low = mid + 1;
            }
            // 중간값이 찾고자하는 값이랑 같은 경우
            else
            {
                // 값을 찾았다.
                return mid;
            }
        }
        // 없다는 반황을 진행
        return -1;
    }

}