

class MyMain
{
    public static void  Main(string[] args) {
        int[] ints = { 1, 2, 3, 4, 5, 6, 11, 7};
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i].ToString() +  " ");
        }
        Console.WriteLine("\n" +  Operations.Max(ints));
        Operations.Swap(ref ints[0], ref ints[6]);

        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i].ToString() + " ");
        }
        Console.WriteLine("\n" +  Operations.SumOfFirstHalfDigits(1233));
    }
}