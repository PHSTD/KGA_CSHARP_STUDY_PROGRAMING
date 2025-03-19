namespace Day250317;

class Program
{
    static void Main(string[] args)
    {
        // string[] shortCuts = new string[4];
        //
        // shortCuts[0] = "포션";
        // shortCuts[1] = "파폭";
        // shortCuts[2] = "부적";
        // shortCuts[3] = "폭탄";
        //
        // for (int i = 0; i < 4; i++) // 인덱스라서 줄여서i로 사용되어온게 국룰
        // {
        //     Console.WriteLine("{0}번째 아이템은 {1} 입니다", i, shortCuts[i]);
        // }
        //
        // for (int i = 0; i < shortCuts.Length; i++) // 인덱스라서 줄여서i로 사용되어온게 국룰
        // {
        //     Console.WriteLine("{0}번째 아이템은 {1} 입니다", i, shortCuts[i]);
        // }
        //
        // // 데이터 집합에서 처음부터 끝까지 하나씩 꺼내서 돌린다
        // foreach (string item in shortCuts)
        // {
        //     Console.WriteLine(item);
        // }
        
        // 2차원 배월(다차원)
        // string[,] students = new string[3, 4];
        // students[0, 0] = "포션";
        // students[0, 1] = "폭탄";
        // students[0, 2] = "섬광";
        // students[0, 3] = "부적";
        
        // students[1, 0] = "허수아비";
        // students[1, 1] = "룬조각";
        // students[1, 2] = "혈액팩";
        // students[1, 3] = "돌덩이";
        
        // students[2, 0] = "마나팩";
        // students[2, 1] = "몬스터캡슐";
        // students[2, 2] = "몬스터볼";
        // students[2, 3] = "이상한사탕";


        // for (int i = 0; i < students.GetLength(0); i++)
        // {
            // for (int j = 0; j < students.GetLength(1); j++)
            // {
                // Console.WriteLine("{0} 번째 줄 {1} 번째 아이템 : {2}", i, j, students[i, j]);
            // }
        // }
        
        // 원하면 얼마든지 더 늘릴 수 있다 (오류남)
        // string[,,] std = new string[3, 8, 30];
        // std[1, 1, 12] = "김전사";
        // std[3, 2, 29] = "이궁수";
        // std[2, 7, 1] = "박도전";
        // Console.WriteLine(std.Length);
        
        // int [,] array = {
             // {1,2,3}   
             // ,{1,2,3}   
             // ,{1,2,3}   
        // };



        // string text = "acCdx";
        // text.ToUpper();
        // text.ToLower();
        // text.Replace('a','x');
        // 2

        // int[] sco = new int[5]; // 크기 5의 배열 선언
        // sco[0] = 10;
        // sco[1] = 10;
        // sco[2] = 10;
        // 값을 대입한다
        
        
        // 배열의 자릿수와 값이다
        // | 0 | 1 | 2 | 3 | 4 | 5 |
        // |10 | 10 | .......
        // 왜 0부터 시작하냐면 "자"도 0 부터 시작해서 2번재 1칸 3번째 2칸 으로 들어간다 배열도 이런식으로 0부터 칸수로 사용한다
        // 이걸 index 라고 부른다
        
        
        // 배열 접근 방법
        // sco[0] = 10; // 0번째 요소 저장
        // Console.WriteLine(sco[1]); // 0번째 요소 불러오기

        
        // int[] sco = new int[5]; // 크기 5의 배열 선언
        // int[] src : 배열로 만들꺼야 
        // new int[5] : 5개의 요소를 만드는것
        
        //  배열이 몇게인지 알고 싶을때  sco.Length로 요소의 총길이를 알 수 있다
        // Console.WriteLine(sco.Length); // 0번째 요소 불러오기

        // string str1 = "포션";
        // string str2 = "부적";
        // int cho = int.Parse(Console.ReadLine());
        
        // switch (cho) {
            // case 1:
                // Console.WriteLine(str1);
                // break;
            // case 2:
                // Console.WriteLine(str2);
                // break;
        // }
        // 변수를 선언해서 사용하면 위처험 해야하지만 배열로 선언 후 작업 시
        // string[] str = new string[4];
        // str[0]="포션";
        // str[1]="부적";
        // str[2]="폭탄";

        // if (str != null)
        // {
            // Console.WriteLine("{} 사용", str[cho]);
        // }
        // else if (cho < str.Length)
        // {
            // Console.WriteLine("범위를 벗어났습니다");
        // }
        // else
        // {
            // Console.WriteLine("없는 아이템");
        // }
        //이렇게 단순화 시킬수 있다

        
        
        
        // int test = 5;
        // Console.WriteLine("함수 전 값 : {0}", test);
        // // 값으로 받기 때문에 원본값은 변하지 않는다
        // IntTest(test); 
        // Console.WriteLine("함수 후 값 : {0}", test);
        // // 주소값을 넘겨주기 때문에 실제 값이 변한다
        // IntTestRef(ref test); 
        // Console.WriteLine("함수 후 값 : {0}", test);
        //
        // // 주소값을 넘겨주기 때문에 실제 값이 변한다
        // // 배열은 무조건 주소값(바로가기)를 가지고 넘기기 때문에
        // int[] test1 = { 1, 2, 3, 4 };
        // ArrIntTest(test1); 
        // Console.WriteLine("함수 후 값 : {0}", test1[2]);
        // // 주소값을 넘겨주기 때문에 실제 값이 변한다
        // // 배열은 무조건 주소값(바로가기)를 가지고 넘기기 때문에
        // // 바꾸고 싶지 않을 경우
        // ArrNoIntTest(test1[2]); 
        // Console.WriteLine("함수 후 값 : {0}", test1[2]);

    }
    // 주소값을 넘겨주기 때문에 실제 값이 변한다 (앝은 복사)
    static void ArrNoIntTest(int value)
    {
        value = 999;
    }
    
    // 값으로 받기 때문에 원본값은 변하지 않는다 (깊은 복사)
    static void IntTest(int value)
    {
        value = value + 10;
    }
    
    // 주소값을 넘겨주기 때문에 실제 값이 변한다 (앝은 복사)
    static void IntTestRef(ref int value) {
        value = value + 10;
    }
    
    // 주소값을 넘겨주기 때문에 실제 값이 변한다 (앝은 복사)
    static void ArrIntTest(int[] value)
    {
        value[2] = 999;
    }
    
}