namespace Day250312_1;

class Program
{
    static void Main(string[] args)
    {
          // Console.Write("골드를 입력해주세요 : ");
        // string input = Console.ReadLine();
        // int age;
        // // input 값을 변환하고 그 값을 age에 넣어준다
        // // 에러로 못해가 아니고 해본다음 안돼면 0을 반환해준다
        // int.TryParse(input, out age);
        // Console.WriteLine("입력하신 골드 : {0}", age); // 성공하면 입력한 값을 넣어주고 실패하면 0 
        // Console.WriteLine("다음년도의 골드 : {0}", age + 1); // 실패 했을 때 1
        
        
        // // 0을 반환되는게 안맞을수 있다 숫자로 0을 입력한건지 잘못 입력한건지 구분해야한다
        // // 즉 성공 실패 여부가 필요
        // Console.Write("골드를 입력해주세요 : ");
        // string input = Console.ReadLine();
        // int gold;
        // // input 값을 변환하고 그 값을 gold에 넣어준다
        // // 에러로 못해가 아니고 해본다음 안돼면 0을 반환해준다
        // // TryParse는 결과가 2개인다(true, false)
        // bool success = int.TryParse(input, out gold); // 성공: true, 실패: false 로 바뀜
        // Console.WriteLine("입력의 유효 여부 : {0}", success); // 성공하면 입력한 값을 넣어주고 실패하면 0 
        // Console.WriteLine("입력하신 골드 : {0}", gold); // 성공하면 입력한 값을 넣어주고 실패하면 0 
        // Console.WriteLine("만원 입금 후 골드 : {0}", gold + 10000); // 실패 했을 때 1
        //
        //
        // int.Parse();// 실수하면 안됨(나만 작성할때)
        // int.TryParse();// 안전하게 사용하길 원할때(유저가 사용하는경우)
        
        
        // // 정수는 소수점을 포함하지 않기 때문에 적어도 둘중 하나는 소수점을 포할할수 있는 포맷형식이면 소수점으로 표시됨 예)  Console.WriteLine(5 / 2f);
        // Console.WriteLine(5 / 2); // 0.25인데 5로 표시됨 정수이기 때문에
        // int award = 9;
        // int partyMember = 4; // 이걸 플롯형으로 만들면 문제가 생긴다(4명으로 해야하는데 문제가 생길수있기 때문에)
        // // 이럴때 사용하는게 임시로 바꾸는 방식이다
        // // 그럼 4.0으로 인식
        // // 이것을 형변환(캐스팅)이라고 한다
        // Console.WriteLine((float) award / partyMember);


        // Console.WriteLine(5 / 2); // 0.25인데 5로 표시됨 정수이기 때문에
        // float distance= 9.8f;
        // int partyMember = 4; // 이걸 플롯형으로 만들면 문제가 생긴다(4명으로 해야하는데 문제가 생길수있기 때문에)
        // Console.WriteLine((int) distance/ partyMember); // distance를 정수로 바꾸고 나는다 (9/4)
        // Console.WriteLine((int) (distance/ partyMember)); // 나눈 최종을 정수형으로 바꾸는것 (2.45f) -> 2로 됨

        // Console.WriteLine(1.1f + 0.3f);

        // 실행된다
        // int hp = 100;
        // int damage;
        // string input = Console.ReadLine();
        // damage = int.Parse(input);

        // 비교 연산자
        // bool alive = hp > damage;
        // 100 > 20 : 100이 20보다 크다 : true
        // 100 < 20 : 100이 20보다 작다 : false
        // 100 >= 100 : 100이 100보다 크거나 같다: true
        // 100 > 100 : 100이 100보다 크다 : false
        // 100 == 100 : 왼쪽이 오른쪽과 똑같으면 : true
        // 100 == 101 : 왼쪽이 오른쪽과 다르면 : false
        // 100 == 100 : 왼쪽이 오른쪽과 같지않다 : false
        // 100 != 101 : 왼쪽이 오른쪽과 같지않다 : true
        //
        // if (alive) // 참일때만 실행
        // {
            // Console.WriteLine("살아남았다!");
        // }
        // Console.WriteLine("끝!");


        // int exp = 150;
        // int level = 1;

        // if (exp >= 100)
        // {
            // 레벨업
            // level++;
            // Console.WriteLine("레벨업!!!!");
            // exp -= 100;
        // }
        // Console.WriteLine("레벨 : {0}", level);
        // Console.WriteLine("결험치 : {0}", exp);
        // Console.WriteLine("끝!");

        // 실행 되지 않는다
        // if (false)
        // {
        // Console.WriteLine("실행되는 블록");
        // }
        
        
        
        
        // 컴퓨터 : 가위
        // 컴퓨터 : 가위
        // Console.WriteLine("가위!! 바위!! 보!!");
        // string playerChoice = Console.ReadLine();
        // if (playerChoice == "바위")
        // {
            // Console.WriteLine("이겼습니다!");
        // }
        // else if (playerChoice == "가위")
        // {
            // Console.WriteLine("비겼습니다");
        // }
        // else if (playerChoice == "보")
        // {
            // Console.WriteLine("젔습니다");
        // }
        // else
        // {
            // Console.WriteLine("잘 못 입력했습니다.");
        // }
        // Console.WriteLine("게임 종료");

        
        // 100 ~ 90: 골드, 89 ~ 80 : 실버, 79 ~ : 브론즈
        // int score = 92;
        // if (score >= 0)
        // {
            // Console.WriteLine("브론즈입니다!");
        // }
        // else if (score >= 80)
        // {
            // Console.WriteLine("실버입니다!");
        // }
        // else if (score >= 90)
        // {
            // Console.WriteLine("골드입니다!");
        // }


        // Console.Write("골드를 입력해주세요 : ");
        // string input = Console.ReadLine();
        // int gold;
        // bool success = int.TryParse(input, out gold); // 성공: true, 실패: false 로 바뀜

        // if (success)
        // {
            // Console.WriteLine("입력하신 골드 : {0}", gold); // 성공하면 입력한 값을 넣어주고 실패하면 0 
            // gold += 10000;
            // Console.WriteLine("만원 입금 후 골드 : {0}", gold); // 실패 했을 때 1
        // }
        // else
        // {
            // Console.WriteLine("잘못된 값을 입력하셨습니다..."); // 성공하면 입력한 값을 넣어주고 실패하면 0 
        // }





        // const int maxItemCount = 8; // const를 쓴이유는 아이템이 8개를 넘지않는다고 생각해서
        // int potionCount = 2;
        // // 포션을 먹으면 인벤토리에 추가한다
        // // ->
        // // 1. 인벤토리가 가득 찼는지 확인해본다.
        // if (potionCount >= maxItemCount)
        // {
        //     //  1-1. 꽉 찼으면 안먹는다.
        //     Console.WriteLine("포션을 먹지 못합니다.");
        // } 
        //   //  1-2. 꽉 차지 않았으면
        //
        // // 2. 이미 포션이 있는지 확인해 본다
        // // 2-1. 이미 포션이 있었으면
        // else if (potionCount >= 1)
        // {
        //     //  2-2. 포션갯수를 하나 늘린다
        //     potionCount++;
        //     Console.WriteLine("인벤토리에 있는 포션에 갯수를 하나 늘립니다!");
        // }  
        // // 3. 포션이 없었으면
        // else if (potionCount == 0)
        // {
        //     //  3-1. 새로 포션을 얻고
        //     potionCount = 1;
        //     //  3-2. 인벤토리에 칸에 표시한다.
        //     Console.WriteLine("인벤토리에 포션을 새로 추가합니다!");
        // }
        
        
        // // 어몽어스 (마피아)
        // // 시민
        // // 1. 모든 임무를 완료하기
        // // 2. 모든 마피아를 검거하기
        // // 둘중 하나라도 만족하면 { "||" : OR }
        // //   1        2
        // if (true || false)
        // {
        //     Console.WriteLine("승리했습니다.");
        // }
        //
        // // 게임 진행 조건
        // // 1. 접속이 되어 있고
        // // 2. 레디 상태일 때
        // // 모두 만족하면 { "&&" : AND }
        // // 하나라도 false있으면 안됨
        // //   1        2
        // if (true && true)
        // {
        //     Console.WriteLine("게임이 가능합니다!");
        // }
        
        // 반전 { "!" : Not }
        // true -> false로
        // false -> true로
        
        
        
        
        
        // switch 조건문 기본
        int value = 5;
        switch (value)
        {
            case 1:
                Console.WriteLine("1입니다.");
                Console.WriteLine("1111");
                Console.WriteLine("1111111111");
                break;
            case 2:
                Console.WriteLine("2 입니다.");
                break;
            case 3:
                Console.WriteLine("3 입니다.");
                break;
            default:
                Console.WriteLine("어느것도 아닙니다.");
                break;
        }
    }
}