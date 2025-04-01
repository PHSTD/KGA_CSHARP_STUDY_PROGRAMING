using Day250401.Team;

namespace Day250401.Scenes;

public class MadnessScene : Scene
{
    public override void Render()
    {
        Utill.Print("당신은 혼에게 몸을 뺏겨 정신이 나갔습니다.");
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
        Game.ChangeScene("Dead");
    }
}