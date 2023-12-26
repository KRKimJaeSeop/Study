internal class Program
{
    private static void Main(string[] args)
    {

        FruitDealer();

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
            Console.WriteLine((A * B) % C);
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
        //10
        void Q1330()
        {
            string input = Console.ReadLine();
            var A = int.Parse(input.Split(" ")[0]);
            var B = int.Parse(input.Split(" ")[1]);
            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (A < B)
            {
                Console.WriteLine("<");

            }
            else if (A == B)
            {
                Console.WriteLine("==");

            }
        }

        void FruitDealer()
        {
            while (true)
            {

                //입력은 1 2 3,4,5,6 이런식으로.
                string input = Console.ReadLine();
                //제출할 답
                int answer = 0;

                // k는 사과의 최고등급 점수다.
                int k = int.Parse(input.Split(" ")[0]);
                // m은 한상자에 들어가는 사과 갯수다.
                int m = int.Parse(input.Split(" ")[1]);
                // score는 사과의 점수 리스트다.
                int[] score = input.Split(" ")[2].Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                // score 정렬
                Array.Sort(score);
                Array.Reverse(score);

                // 박스의 갯수를 구한다.
                var boxAmount = score.Length / m;
                // 수가 딱떨어지지 않으면 박스를 하나 더한다.
                if (score.Length % m > 0)
                    boxAmount++;

                // 큰 배열이 박스들, 작은배열은 박스안의 사과들
                List<List<int>> boxes = new List<List<int>>();

                // 박스배열 세팅.
                for (int i = 0; i < boxAmount; i++)
                {
                    boxes.Add(new List<int>());
                }

                // 사과번호 순서대로 박스에 넣는다. 넣을 박스는 번호/m
                for (int i = 0; i < score.Length; i++)
                {
                    var a = i / m;
                    boxes[a].Add(score[i]);
                }


                foreach (var box in boxes)
                {
                    if(box.Count == m)
                    {
                        var a = box[box.Count-1] * box.Count;
                        answer += a;
                    }
              
                }

            }


        }
    }
}