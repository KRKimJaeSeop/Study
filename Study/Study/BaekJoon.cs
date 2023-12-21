internal class Program
{
    private static void Main(string[] args)
    {

        Q1000();

        void Q2557()
        {
            Console.WriteLine("Hello World!");

        }

        void Q1000()
        {
            var input = Console.ReadLine() as string;
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            Console.WriteLine(A+B);
        }

    }
}