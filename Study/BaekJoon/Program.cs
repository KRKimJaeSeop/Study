internal class Program
{
    private static void Main(string[] args)
    {

        Q3003();

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
                    if (box.Count == m)
                    {
                        var a = box[box.Count - 1] * box.Count;
                        answer += a;
                    }

                }

            }


        }

        void Tournament()
        {
            //https://school.programmers.co.kr/learn/courses/30/lessons/12985
            while (true)
            {
                //입력은 1 2 3 이런식으로.
                string input = Console.ReadLine();

                // n은 참가자의 수
                int n = int.Parse(input.Split(" ")[0]);
                // a는 본인의 번호
                int a = int.Parse(input.Split(" ")[1]);
                // b는 경쟁자 번호
                int b = int.Parse(input.Split(" ")[2]);
                int answer = 0;

                // 라운드가 올라갈때마다 번호가 다시 부여된다.
                // 대진에서 만난다는건 번호가 같아진다는걸 뜻한다.
                //짝수는 다음라운드에 /2가 되고, 홀수는 /2+1이 된다.
                while (a != b)
                {
                    a = a / 2 + a % 2;
                    b = b / 2 + b % 2;
                    answer++;
                }

                //제출할 답
                Console.WriteLine(answer);
            }
        }

        void SoloPlay()
        {
            //입력은 1 2 3 이런식으로.
            string input = Console.ReadLine();

            // n은 참가자의 수
            int k = int.Parse(input.Split(" ")[0]);
            // a는 본인의 번호
            int a = int.Parse(input.Split(" ")[1]);
            // b는 경쟁자 번호
            int b = int.Parse(input.Split(" ")[2]);


        }

        void Q3003()
        {
            //입력은 1 2 3 이런식으로.
            string input = Console.ReadLine();
            var splitString = input.Split(" ");

            // k 킹
            int K = 1-int.Parse(splitString[0]);
            // q 퀸
            int Q = 1-int.Parse(splitString[1]);
            // R 룩
            int R = 2-int.Parse(splitString[2]);
            // v 비숍
            int V = 2-int.Parse(splitString[3]);
            // N 나이트
            int N = 2-int.Parse(splitString[4]);
            // P 폰
            int P = 8-int.Parse(splitString[5]);


            Console.WriteLine($"{K} {Q} {R} {V} {N} {P}");



        }
    }
}