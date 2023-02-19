namespace caProvaTarget;

public static class ClsFibonacci
{
    private static bool achou;

    public static bool Fibonacci(int len)
    {
        achou = false;

        return FibonacciTemporario(0, 1, 1, len);
    }

    private static bool FibonacciTemporario(int a, int b, int counter, int len)
    {
        if (len == b || len == a) achou = true;

        if (counter <= len)
        {
            FibonacciTemporario(b, a + b, counter + 1, len);
        }

        return achou;
    }
}