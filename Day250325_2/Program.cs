namespace Day250325_2;

class Program
{
    
class Car
{
    public Car()
    {
        Console.WriteLine("부모 생성자");
    }
}

class Truck : Car
{
    public Truck()
    {
        Console.WriteLine("자식 생성자");
    }
}
    static void Main(string[] args)
    {
        Truck truck = new Truck();
    }
}