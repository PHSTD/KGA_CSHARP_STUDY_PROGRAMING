
namespace _01.HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "모민호";
        float foot1 = 275.0f;
        int age1 = 33;
        string major1 = "토목공학";
        string fun1 = "운동";
        bool friend1 = false;
        Console.WriteLine("이름: {0}, 발사이즈: {1}, 나이: {2}, 전공: {3}, 취미: {4}, 애인: {5}", name1, foot1, age1, major1, fun1, friend1);
        
        string name2 = "장현태";
        float foot2 = 265.0f;
        int age2 = 27;
        string major2 = "멀티미디어";
        string fun2 = "운동";
        bool friend2 = false;
        Console.WriteLine("이름: {0}, 발사이즈: {1}, 나이: {2}, 전공: {3}, 취미: {4}, 애인: {5}", name2, foot2, age2, major2, fun2, friend2);
        
        string name3 = "김용석";
        float foot3 = 265.0f;
        int age3 = 36;
        string major3 = "화학공학";
        string fun3 = "비디오 게임";
        bool friend3 = true;
        Console.WriteLine("이름: {0}, 발사이즈: {1}, 나이: {2}, 전공: {3}, 취미: {4}, 애인: {5}", name3, foot3, age3, major3, fun3, friend3);
        
        string name4 = "조기훈";
        float foot4 = 245.0f;
        int age4 = 31;
        string major4 = "소프트웨어";
        string fun4 = "복싱";
        bool friend4 = false;
        Console.WriteLine("이름: {0}, 발사이즈: {1}, 나이: {2}, 전공: {3}, 취미: {4}, 애인: {5}", name4, foot4, age4, major4, fun4, friend4);
        
        // for (int i = 1; i < 5; i++)
        // {
            // Console.WriteLine("이름: {0}, 발사이즈: {1}, 나이: {2}, 전공: {3}, 취미: {4}, 애인: {5}", "name"+i, "foot"+i, "age"+i, "major"+i, "fun"+i, "friend"+i);
        // }

    }
}