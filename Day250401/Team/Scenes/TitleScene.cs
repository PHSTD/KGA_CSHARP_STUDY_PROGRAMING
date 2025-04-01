using Day250401.Team;

namespace Day250401.Scenes;

public class TitleScene : Scene
{
    public override void Render()
    {
        Utill.Print("************************************", ConsoleColor.Red , 9);
        Utill.Print("         나혼자 숨바꼭질", ConsoleColor.Red , 9);
        Utill.Print("************************************", ConsoleColor.Red, 9);
        Console.WriteLine();
    }

    public override void Choice()
    {
        Utill.Print("1. 시작하기", ConsoleColor.Red, 50);
        Utill.Print("2. 불러오기(미구현)", ConsoleColor.Gray, 50);
        Utill.Print("3. 설정", ConsoleColor.Yellow, 50);
        Utill.Print("4. 종료하기", ConsoleColor.White, 50);
    }

    public override void Result()
    {
    }

    public override void Wait()
    {
    }

    public override void Next()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Check");
                break;
            case ConsoleKey.D2:
                Game.ChangeScene("");
                break;
            case ConsoleKey.D3:
                Game.ChangeScene("Setting");
                break;
            case ConsoleKey.D4:
                Game.GameOver(true); 
                break;
        }
    }
}