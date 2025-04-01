using Day250401.Team;

namespace Day250401.Scenes;

public class SettingScene : Scene
{
    public override void Render()
    {
        Utill.Print("환경설정");
    }

    public override void Choice()
    {
        Utill.Print("1. 음악설정");
        Utill.Print("2. 그래픽설정");
        Utill.Print("3. 메인으로");
    }

    public override void Result()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Utill.Print("사운드를 설정합니다");
                break;
            case ConsoleKey.D2:
                Utill.Print("그래픽를 설정합니다");
                break;
            case ConsoleKey.D3:
                Utill.Print("타이틀로 돌아갑니다");
                break;
        }
    }

    public override void Wait()
    {
        Utill.Print("아무키나 입력하세요");
        Console.ReadKey();
        
    }

    public override void Next()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Title");
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