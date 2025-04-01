using Day250401.Team;

namespace Day250401.Scenes;

public class ExitScene : Scene
{
    public override void Render()
    {
        Utill.Print("다행히 무슨일 없이 화장실에 인형이 있습니다.");
        Utill.Print("당신은 숨바꼭질을 마무리 했습니다.");
        Game.GameOver(true);
    }

    public override void Choice()
    {
    }

    public override void Result()
    {
    }

    public override void Wait()
    {
    }

    public override void Next()
    {
        Game.ChangeScene("Title");
    }
}