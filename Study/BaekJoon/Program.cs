internal class Program
{
    private static void Main(string[] args)
    {

        PellinDrome();

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

            // c 는 카드.    
            int[] cards = input.Split(" ").Select(n => Convert.ToInt32(n)).ToArray();

            bool[] opened = new bool[cards.Length];

            // 각 그룹의 점수들. 그룹은 여러개일 수 있다.
            List<int> group = new List<int>();

            // 선택할 카드의 번호.
            int openIndex = 0;

            // 게임 시작
            // 모든 카드가 뒤집힐때까지 반복한다.
            while (opened.Contains(false))
            {
                // 카드 중 아직 뒤집혀지지 않은 카드를 선택한다.
                openIndex = Array.IndexOf(opened, false);
                // 그룹을 추가한다.
                group.Add(0);

                // 게임중.. 선택된 그룹 안에서 돈다.
                // 게임을 뒤집힌 카드를 고를때까지 반복한다.
                while (true)
                {
                    // 열어볼 인덱스의 카드가 뒤집혀있지 않다면.
                    if (!opened[openIndex])
                    {
                        // 카드를 뒤집는다.
                        opened[openIndex] = true;
                        // 현재 group에 1점을 더한다.
                        group[group.Count - 1]++;
                        // 열어볼 인덱스를 방금 뒤집은 카드의 숫자로 정한다.
                        openIndex = cards[openIndex] - 1;
                    }
                    // 연 카드가 이미 뒤집혀있는 카드라면 지금 그룹을 끝낸다.
                    else
                    {
                        break;
                    }
                }


            }
            // 그룹을 내림차순으로 정렬한다.
            group.Sort((a, b) => b.CompareTo(a));

            //그룹이 두개 이상일 경우 첫번째 두번째그룹을 곱하고, 아닐 경우 점수는 0점이다.
            int answer = (group.Count > 1) ? group[0] * group[1] : 0;

        }

        void Q3003()
        {
            //입력은 1 2 3 이런식으로.
            string input = Console.ReadLine();
            var splitString = input.Split(" ");

            // k 킹
            int K = 1 - int.Parse(splitString[0]);
            // q 퀸
            int Q = 1 - int.Parse(splitString[1]);
            // R 룩
            int R = 2 - int.Parse(splitString[2]);
            // v 비숍
            int V = 2 - int.Parse(splitString[3]);
            // N 나이트
            int N = 2 - int.Parse(splitString[4]);
            // P 폰
            int P = 8 - int.Parse(splitString[5]);


            Console.WriteLine($"{K} {Q} {R} {V} {N} {P}");



        }

        //하나하나 실행시키고 나온 값으로 비교
        long GoldSilver(int needGold, int needSilver, int[] cityGold, int[] citySilver, int[] cityWeight, int[] cityTime)
        {
            long answer = 0;


            var moveTime = new int[cityGold.Length];

            for (int i = 0; i < cityGold.Length; i++)
            {

                // 금와 은이 모두 소진됐다면 탈출한다.
                if (needGold + needSilver <= 0)
                    break;

                // 해당 도시의 금과 은이 소진되거나, 해당 도시에서 더 챙길게 없거나,
                // 필요한 금와 은을 다 모을때까지 한 도시만 반복한다.
                while (cityGold[i] + citySilver[i] > 0 && needGold + needSilver > 0)
                {

                    //도시에서 공사장으로
                    moveTime[i]++;

                    if (cityGold[i] > 0 && needGold == 0)
                    {
                        break;
                    }
                    if (citySilver[i] > 0 && needSilver == 0)
                    {
                        break;
                    }

                    // _g는 이번턴에 뺄 금
                    int _g = needGold;
                    // 도시의 보유량보다 많다면 보유량으로 맞춘다.
                    if (_g > cityGold[i])
                        _g = cityGold[i];
                    // _s는 이번턴에 뺄 은
                    int _s = needSilver;
                    // 도시의 보유량보다 많다면 보유량으로 맞춘다.
                    if (_s > citySilver[i])
                        _s = citySilver[i];

                    // 만약 뺄 양의 합이 적재무게를 초과한다면
                    if (_g + _s > cityWeight[i])
                    {
                        // 초과하는 양인 over를 구한다.
                        int over = (_g + _s) - cityWeight[i];

                        // 뺄 계획인 금과 은에서 무게를 over와 같아질때까지 덜어야한다.

                        // 빼려는 금이 over보다 많거나 같다면 / 빼려는 금에서 over를 빼고 over를 없앤다.
                        if (_g >= over)
                        {
                            _g -= over;
                            over = 0;
                        }
                        // 빼려는 금이 over보다 작다면 / over에서 빼려는 금을 빼고, 
                        else
                        {
                            over -= _g;
                            _g = 0;
                        }
                        // 빼려는 은이 over보다 많거나 같다면
                        if (_s >= over)
                        {
                            _s -= over;
                            over = 0;
                        }
                        // 빼려는 금이 over보다 작다면 일단 빼려는 금 만큼만 처리한다.
                        else
                        {
                            over -= _s;
                            _s = 0;
                        }


                    }
                    //초과하지 않았다면, 뺄 양을 그대로 뺀다.
                    //전체 필요한 양에서도 뺴고 해당 도시의 양에서도 뺀다.
                    needGold -= _g;
                    cityGold[i] -= _g;
                    needSilver -= _s;
                    citySilver[i] -= _s;


                    //더 옮겨야한다면
                    if (needGold + needSilver > 0)
                    {
                        //공사장에서 도시로
                        moveTime[i]++;
                    }


                }

            }
            for (int i = 0; i < moveTime.Length; i++)
            {
                // 횟수에 시간 곱함.
                moveTime[i] *= cityTime[i];
            }
            // 동시에 진행되기 떄문에 정렬해서 0번째만 리턴한다.
            Array.Reverse(moveTime);
            answer = moveTime[0];
            Console.WriteLine(answer);
            return answer;
        }

        // 어떤걸로 돌리는게 가장 최댓값일지 최적화 후 하나만 돌림
        long GoldSilver_2(int needGold, int needSilver, int[] cityGold, int[] citySilver, int[] cityWeight, int[] cityTime)
        {
            long answer = 0;

            var maxvalues = new long[cityTime.Length];
            // 최댓값 = 최대 왕복해야하는 수 * 시간
            // 왕복해야하는 수  = {(필요량 or 보유량) / 적재량 } * 시간
            // 
            for (int i = 0; i < maxvalues.Length; i++)
            {
                var amount = ((needGold + needSilver) > (cityGold[i] + citySilver[i])) ? (needGold + needSilver) : (cityGold[i] + citySilver[i]);

                maxvalues[i] = amount / cityWeight[i] * cityTime[i];
            }

            // 가장 오래걸리는 도시의 인덱스
            var LatestIndex = Array.IndexOf(maxvalues, maxvalues.Max());
            var moveTime = 0;
            // 해당 도시만 실행시킨다.
            while (true)
            {
                // 아래 조건이라면 탈출한다.
                if (cityGold[LatestIndex] > 0 && needGold == 0)
                {
                    break;
                }
                if (citySilver[LatestIndex] > 0 && needSilver == 0)
                {
                    break;
                }

            }

            Console.WriteLine(answer);
            return answer;
        }

        void VocaStudy()
        {
            var word = Console.ReadLine();
            var array = word?.ToUpper().ToCharArray();
            if (array != null)
            {
                var spellsCount = new Dictionary<char, int>();
                foreach (var spell in array)
                {
                    if (spellsCount.ContainsKey(spell))
                        spellsCount[spell]++;
                    else
                        spellsCount.Add(spell, 1);
                }

                var sortedArray = spellsCount.OrderByDescending(x => x.Value);
                var spellsCount2 = new Dictionary<char, int>();

                foreach (var spell in sortedArray)
                {
                    spellsCount2.Add(spell.Key, spell.Value);
                }

                var first = spellsCount2.First();
                if (spellsCount2.Count < 2)
                {
                    Console.WriteLine(first.Key);
                }
                else
                {
                    spellsCount2.Remove(first.Key);
                    var second = spellsCount2.First();
                    if (first.Value == second.Value)
                    {
                        Console.WriteLine("?");
                    }
                    else
                    {
                        Console.WriteLine(first.Key);
                    }
                }

            }
        }



        void MakeStar()
        {
            var input = Console.ReadLine();
            if (input == null)
                return;

            var repeatTime = (int.Parse(input) * 2) - 1;

            int i = 1;
            int k = 1;
            while (true)
            {
                var LineTimeLimit = i * 2 - 1;  //0
                if (k <= repeatTime / 2)
                {
                    for (int j = 0; j < (repeatTime / 2 + 1) - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < LineTimeLimit; j++)
                    {
                        Console.Write("*");
                    }
                    i++;
                }
                else
                {
                    for (int j = 0; j < (repeatTime / 2 + 1) - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = LineTimeLimit; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    i--;
                }
                k++;

                if (i > 0)
                    Console.WriteLine();

                else
                    break;
            }

        }


        void PellinDrome()
        {
            var input = Console.ReadLine();
            if (input == null)
                return;
            var original = input.ToCharArray();
            var reverse = original.Reverse().ToArray();

            char output = '1';

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] != reverse[i])
                {
                    output = '0';
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
