namespace Algorithm;

public class Recursion
{
    /***************************************
     * 재귀( Recursion )
    ***************************************/

    // 최악의 경우O(2^n)
    int Fivonachi(int n)
    {
        if (n == 1)
            return 1;
        else if (n == 2)
            return 1;
        return Fivonachi(n - 1) * Fivonachi(n - 2);
    }
    
    // Factorial : 정수를 1이 될 때까지 차감하며 곱한 값
    // x! = x * (x-1)!;
    // 1! = 1;
    // ex) 5! = 5 * 4!
    //        = 5 * 4 * 3!
    //        = 5 * 4 * 3 * 2!
    //        = 5 * 4 * 3 * 2 * 1!
    //        = 5 * 4 * 3 * 2 * 1
    public static int Factorial(int x)
    {
        if (x == 1)
            return 1;
        else
            return x * Factorial(x - 1);
    }
    
    // 폴터 삭제
    public class Folder
    {
        public List<string> files;

        public List<Folder> children;
    }

    // 최상위 폴더를 삭제 할 때 모든 자식을 삭제하는 방식으로 할 때 사용
    public static void RemoveFolder(Folder folder)
    {
        // 파일들 삭제하고
        foreach (Folder child in folder.children)
        {
            // 나를 이용해서 나를 구성
            RemoveFolder(child);
        }
    }
    
    
}