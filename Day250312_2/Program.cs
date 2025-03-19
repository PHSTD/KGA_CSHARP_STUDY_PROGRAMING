namespace Day250312_2;

class Program
{
    static void Main(string[] args)
    {
                // 프로그램 사용자의 입력을 받아 계산을 수행하는 계산기를 구현하시오
        // 프로그램 실행 시 정수를 두 개 입력받습니다.
        Console.Write("첫번째 값을 입력해 주세요 : ");
        int intger1 = int.Parse(Console.ReadLine());
        Console.Write("두번째 값을 입력해 주세요 : ");
        int intger2 = int.Parse(Console.ReadLine());
        // 두 번째 줄에는 +, -, *, /, % 중 하나를 입력받도록 하며, 이외의 문자 입력 시 프로그램이 종료되도록 구성합니다
        Console.Write("연산자 기호를 입력해 주세요(+, -, *, /, %) : ");
        char operator1 = char.Parse(Console.ReadLine());

        switch (operator1)
        {
            case '+':
                Console.WriteLine("{0} {1} {2} = {3}", intger1, operator1, intger2, intger1 + intger2);
                break;
            case '-':
                Console.WriteLine("{0} {1} {2} = {3}", intger1, operator1, intger2, intger1 - intger2);
                break;
            case '*':
                Console.WriteLine("{0} {1} {2} = {3}", intger1, operator1, intger2, intger1 * intger2);
                break;
            case '/':
                if (intger2 == 0)
                {
                    Console.WriteLine("프로그램 종료");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", intger1, operator1, intger2, intger1 / intger2);
                }
                break;
            case '%':
                if (intger2 == 0)
                {
                    Console.WriteLine("프로그램 종료");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", intger1, operator1, intger2, intger1 % intger2);
                }
                break;
            default:
                Console.WriteLine("프로그램 종료");
                break;
            
        }
        
        // 각 연산자는 아래와 같은 결과를 출력하도록 소스코드를 구성합니다.
        // + : 두 수를 더한 값을 출력한다
        // - : 두 수를 뺀 값을 출력한다
        // * : 두 수를 곱한 값을 출력한다
        // / : 두 수를 나눈 값을 출력한다(단, 두 번째 숫자가 0인 경우 프로그램을 종료한다)
        // % : 두 수를 나눈 값의 나머지를 출력한다(단, 두 번째 숫자가 0인 경우 프로그램을 종료한다)
    }
}