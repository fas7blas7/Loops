namespace _3_BiggestNumber
{
    internal class BiggestNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}