using Day250401.Scenes;

namespace Day250401.Team;

public class Game
{

    private static bool gameOver;

    private static Dictionary<string, Scene> sceneDic;
    private static Scene curScene;
    

    public static void Start()
    {
        // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
        sceneDic = new Dictionary<string, Scene>();
        sceneDic.Add("Title", new TitleScene());
        sceneDic.Add("Check", new CheckScene());
        sceneDic.Add("Setting", new SettingScene());
        sceneDic.Add("Start", new StartScene());
        sceneDic.Add("Dead", new DeadScene());
        sceneDic.Add("Exit", new ExitScene());
        sceneDic.Add("Madness", new MadnessScene());
        

        curScene = sceneDic["Title"];
    }

    public static void Run()
    {
        while (gameOver == false)
        {
            Console.Clear();
            curScene.Render();
            Console.WriteLine();
            curScene.Choice();
            Console.WriteLine();
            curScene.Input();
            curScene.Result();
            Console.WriteLine();
            curScene.Wait();
            curScene.Next();
        }
    }

    public static void End()
    {
    }

    public static void GameOver(bool _gameOver)
    {
        gameOver = _gameOver;
    }

    public static void ChangeScene(string sceneName)
    {
        curScene = sceneDic[sceneName];
    }
}