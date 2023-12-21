internal class Program
{
    private static void Main(string[] args)
    {

        Q10171();

        //1
        void Q2557()
        {
            Console.WriteLine("Hello World!");

        }
        //2
        void Q1000()
        {
            var input = Console.ReadLine() as string;
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            Console.WriteLine(A + B);
        }
        //3
        void Q1001()
        {
            var input = Console.ReadLine() as string;
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            Console.WriteLine(A - B);
        }
        //4
        void Q10998()
        {
            var input = Console.ReadLine() as string;
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            Console.WriteLine(A * B);
        }
        //5
        void Q10869()
        {
            var input = Console.ReadLine() as string;
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
        //6
        void Q10926()
        {

            while (true)
            {
                var input = Console.ReadLine() as string;

                if (input.Length <= 50)
                {
                    Console.WriteLine($"{input}??!");
                    break;
                }
            }

        }
        //7
        void Q18108()
        {
            var input = Console.ReadLine() as string;
            Console.WriteLine(int.Parse(input) - 543);

        }
        //8
        void Q10430()
        {
            string input = Console.ReadLine();
            var array = input.Split(" ");
            var A = int.Parse(array[0]);
            var B = int.Parse(array[1]);
            var C = int.Parse(array[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
        //9
        void Q10171()
        {
            Console.WriteLine("\\    /\\");
            Console.WriteLine(" )  ( ')");
            Console.WriteLine("(  /  )");
            Console.WriteLine(" \\(__)|");

        }

    }
}