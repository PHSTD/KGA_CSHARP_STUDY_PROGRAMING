using Day250401.Team;

namespace Day250401.Scenes;

public class CheckScene : Scene
{
    public override void Render()
    {
        Utill.Print("당신은 혼자 집에 있습니다.", ConsoleColor.Red, 50);
        Utill.Print("정말로 강령술을 시작하시겠습니까?.", ConsoleColor.Red, 50);
    }

    public override void Choice()
    {
        Utill.Print("1. 시작한다", ConsoleColor.Red, 50);
        Utill.Print("2. 멈춘다", ConsoleColor.Red, 50);
        Utill.Print("3. 타이틀 화면으로.", ConsoleColor.Red, 50);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("입력해주세요 : ");
        Console.ResetColor();
    }

    public override void Result()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Utill.Print("손발이 있는 봉제인형을 가져옵니다.", ConsoleColor.Red, 50);
                Utill.Print("인형을 가득 채울 수 있는 정도의 쌀을 준비합니다", ConsoleColor.Red, 50);
                Utill.Print("손톱깍이를 준비합니다", ConsoleColor.Red, 50);
                Utill.Print("바늘과 붉은 실을 준비합니다.", ConsoleColor.Red, 50);
                Utill.Print("칼이나 커터칼,송곳등을 준비합니다", ConsoleColor.Red, 50);
                Utill.Print("한잔 정도의 소금물을(천연 소금) 준비합니다.", ConsoleColor.Red, 50);
                Utill.Print("이제 준비를 모두 마쳤습니다.", ConsoleColor.Red, 50);
                Utill.Print("봉제인형에 이름을 붙입니다 충전재를 모드 꺼내고 쌀과 자신의 손톱을 넣어 봉합합니다.", ConsoleColor.Red, 50);
                Utill.Print("남아있는 실은 어느 정도 인형에 감아 묶는다. 숨겨진 장소를 정해두고 거기에 소금물을 준비해준다.", ConsoleColor.Red, 50);
                Utill.PrintLine("당신은 03시 00분까지 기다리고 있습니다.", ConsoleColor.Red, 50);
                Utill.Print("당신은 03시 00분까지 기다리고 있습니다.", ConsoleColor.Red, 50);
                Utill.Print("이제 03시 00분이 되었습니다.", ConsoleColor.Red, 50);
                Utill.Print("집안의 조명을 모두 끄고 TV만 켜고 눈을 감고 10초 셉니다.", ConsoleColor.Red, 50);
                Utill.Print("칼을 가지고 욕실로 가서 [XX 발견했다]고 말하고 찌릅니다.", ConsoleColor.Red, 50);
                Utill.Print("[다음은 XX이 술래]라고 말하고 자신은 소금물이 있는 은신처에 숨는다.", ConsoleColor.Red, 50);
                break;
        }
    }

    public override void Wait()
    {
        Utill.Print("계속할려면 아무키나 누르세요", ConsoleColor.Red, 100);
        Console.ReadKey();
    }

    public override void Next()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Start");
                break;
            case ConsoleKey.D2:
                Game.ChangeScene("Title");
                break;
            case ConsoleKey.D3:
                Game.ChangeScene("Title");
                break;
        }
    }
}