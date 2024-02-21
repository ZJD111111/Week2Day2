namespace app1;

class RevertArray
{
    // static void Main(string[] args)
    // {
    //     int[] numbers = GenerateNumbers(10);
    //     Revert(numbers);
    //     PrintNumbers(numbers);
    // }
    static int[] GenerateNumbers(int len)
    {
        int[] result = new int[len];
        for (int i = 1; i < len + 1; i++)
        {
            result[i - 1] = i;
        }
        return result;
    }
    static void Revert(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
    static void PrintNumbers(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

}