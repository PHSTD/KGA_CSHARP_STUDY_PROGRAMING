namespace Day250314_1;

class Program
{
    // static void MakeFishCake()
    // {
        // Console.WriteLine("반죽물을 붓습니다.");
        // Console.WriteLine("팥을 넣습니다.");
        // Console.WriteLine("익을때 까지 기다립니다.");
        // Console.WriteLine("팥 붕어팡 완성!!!");
    // }
    
    // static void MakechreamFishCake()
    // {
        // Console.WriteLine("반죽물을 붓습니다.");
        // Console.WriteLine("슈크림을 넣습니다.");
        // Console.WriteLine("익을때 까지 기다립니다.");
        // Console.WriteLine("슈크림 붕어팡 완성!!!");
    // }

    // static void MakeFish(string test)
    // {
        // Console.WriteLine("반죽물을 붓습니다.");
        // Console.WriteLine("{0}을 넣습니다.", test);
        // Console.WriteLine("익을때 까지 기다립니다.");
        // Console.WriteLine("{0} 붕어팡 완성!!!", test);
    // }


    static int function()
    {
        Console.WriteLine("단계1");
        Console.WriteLine("단계2");
        return 10; // 이미 결과가 나왔기 때문에 아래구문은 실행하지 않는다
        Console.WriteLine("단계3");
        Console.WriteLine("단계4");
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(function());
    }
}