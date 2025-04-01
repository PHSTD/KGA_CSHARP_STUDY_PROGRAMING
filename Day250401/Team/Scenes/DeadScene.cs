using Day250401.Team;

namespace Day250401.Scenes;

public class DeadScene : Scene
{
    public override void Render()
    {
        Utill.Print("당신은 인형과 마주쳤습니다.");
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