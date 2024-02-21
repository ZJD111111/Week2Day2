namespace app1;
class Fibonaccis
{
    // static void Main(string[] args)
    // {
    //     int num = 10;
    //     for (int i = 1; i < num + 1; i++)
    //     {
    //         Console.Write(Fibonacci(i) + " ");
    //     }
    // }
    static int Fibonacci(int num)
    {
        if (num == 1 || num == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}