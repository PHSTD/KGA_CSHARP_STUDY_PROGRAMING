using Day250401.Team;

namespace Day250401.Scenes;

public class StartScene : Scene
{
    public override void Render()
    {
        Utill.Print("치..지직.....치...지직....");
        Utill.Print("TV의 신호음이 들린다.");
        Utill.Print("채널이 자동으로 변경 되면서 주파수 음에 맞춰 말소리가 들리기 시작합니다");
        Utill.Print("당신은 공포에 빠져 혼란스럽기 시작합니다.");
    }

    public override void Choice()
    {
        Utill.Print("1. 입에 소금물을 머금고 화장실로 간다");
        Utill.Print("2. 입에 소금물을 머금고 인형을 찾으로 간다");
        Utill.Print("3. 공포로 인해 몸이 굳어 그대로 숨어 있는다");
        Utill.Print("4. 재밋다고 들떠있는다");
        Utill.Print("5. 인형이 잘 있나 찾아다닌다");
    }

    public override void Result()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Utill.Print("당신은 몸을 떨면서 화장실로 향한다");
                break;
            case ConsoleKey.D2:
                Utill.Print("당신은 인형이 잘 있 확인하러 화장실로 향한다");
                break;
            case ConsoleKey.D3:
                Utill.Print("당신은 몸을 떨면서 몸이 굳어 움직이지 못하고 숨어있습니다.");
                break;
            case ConsoleKey.D4:
                Utill.Print("당신은 진짜 인형에 혼이 들어갔나 싶어 재밌어하고 있습니다.");
                break;
            case ConsoleKey.D5:
                Utill.Print("당신은 화장실로 향했습니다. 그곳엔 인형이 없었습니다.");
                Utill.Print("공포에 빠졌습니다.");
                break;
        }
        
    }

    public override void Wait()
    {
    }

    public override void Next()
    {
        Random random = new Random();
        int randomNumber = random.Next(3);
        switch (input)
        {
            case ConsoleKey.D1:
                    Game.ChangeScene("Exit");
                break;
            case ConsoleKey.D2:
                    if (randomNumber == 0)
                    {
                        Game.ChangeScene("Dead");
                    }
                break;
            case ConsoleKey.D3:
                break;
            case ConsoleKey.D4:
                    Game.ChangeScene("Madness");
                    Game.ChangeScene("Exit");
                break;
            case ConsoleKey.D5:
                    Game.ChangeScene("Madness");
                    Game.ChangeScene("Exit");
                break;
        }
    }
}