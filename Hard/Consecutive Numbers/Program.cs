class Program
{
    static void Main(string[] args)
    {
    }
    static bool Cons(int[] arr)
    {
        Array.Sort(arr);
        int counter = 1;
        var min = arr.Min();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != 0 && arr[i] == min + i) counter++;
        }
        return counter == arr.Length;
    }
}