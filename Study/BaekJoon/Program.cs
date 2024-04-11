using System.Collections;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        SortNumber();

        //-------------------------------------------------------
        // 심화1
        {
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

            void Croatia()
            {
                var input = Console.ReadLine();
                if (input == null)
                    return;
                var answer = input.Replace("c=", "o")
                     .Replace("c-", "o")
                     .Replace("dz=", "o")
                     .Replace("d-", "o")
                     .Replace("lj", "o")
                     .Replace("nj", "o")
                     .Replace("s=", "o")
                     .Replace("z=", "o");

                Console.WriteLine(answer.Length);

            }

            void GroupWordChecker()
            {
                var input = Console.ReadLine();
                if (input == null)
                    return;
                var wordsList = new List<string>();

                //입력
                for (int i = 0; i < int.Parse(input); i++)
                {
                    var world = Console.ReadLine();
                    wordsList.Add(world);
                }

                var answer = 0;

                //단어 전체
                for (int i = 0; i < wordsList.Count; i++)
                {
                    bool isGroupWord = true;
                    var array = new List<char>();

                    //단어 하나
                    for (int j = 0; j < wordsList[i].Length; j++)
                    {

                        if (!array.Contains(wordsList[i][j]))
                        {
                            array.Add(wordsList[i][j]);
                        }
                        else
                        {
                            if (wordsList[i][j - 1] != wordsList[i][j])
                            {
                                isGroupWord = false;
                                break;
                            }
                        }
                    }

                    if (isGroupWord)
                        answer++;
                }

                Console.WriteLine(answer);

            }

            void ArrayMax()
            {

                var Numbers = new int[9];
                //입력
                for (int i = 0; i < 9; i++)
                {
                    var number = Console.ReadLine();
                    Numbers[i] = int.Parse(number);
                }
                var max = Numbers.Max();
                Console.WriteLine(max);
                Console.WriteLine(Array.IndexOf(Numbers, max) + 1);

            }

            void Grade()
            {
                var Grades = new string[20];
                //입력
                // 전공평점 = (학점 x 과목평점)의 총 합 / 학점의 총합
                // 학점은 가운데 숫자
                for (int i = 0; i < 20; i++)
                {
                    var grade = Console.ReadLine();
                    Grades[i] = grade;
                }

                var answer = 0.0d;
                var sum = 0.0d;

                for (int i = 0; i < Grades.Length; i++)
                {
                    //학점
                    var score = double.Parse(Grades[i].Split(" ")[1]);
                    //과목평점
                    var grade = 0.0d;
                    switch (Grades[i].Split(" ")[2])
                    {
                        case "A+":
                            grade = 4.5d;
                            break;
                        case "A0":
                            grade = 4.0d;
                            break;
                        case "B+":
                            grade = 3.5d;
                            break;
                        case "B0":
                            grade = 3.0d;
                            break;
                        case "C+":
                            grade = 2.5d;
                            break;
                        case "C0":
                            grade = 2.0d;
                            break;
                        case "D+":
                            grade = 1.5d;
                            break;
                        case "D0":
                            grade = 1.0d;
                            break;
                        case "F":
                            grade = 0.0d;
                            break;
                        case "P":
                            grade = -1.0d;
                            break;
                        default:
                            grade = 0.0d;
                            break;
                    }

                    if (grade == -1.0d)
                        continue;
                    answer += (score * grade);
                    sum += score;
                }

                if (sum == 0)
                {
                    answer = 0.000000;
                }
                else
                {
                    answer = answer / sum;
                }
                Console.WriteLine($"{answer}");
            }

            void Plant()
            {
                Console.WriteLine("         ,r'\"7");
                Console.WriteLine("r`-_   ,'  ,/");
                Console.WriteLine(" \\. \". L_r'");
                Console.WriteLine("   `~\\/");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
            }


        }

        // 2차원 배열
        {
            void MatrixAddition()
            {
                var input = Console.ReadLine();
                var row = int.Parse(input.Split(" ")[0]);
                var column = int.Parse(input.Split(" ")[1]);

                //첫번째 2차원 배열
                var array01 = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    var contents = Console.ReadLine();
                    var rows = contents.Split(" ");
                    for (int j = 0; j < column; j++)
                    {
                        array01[i, j] = int.Parse(rows[j]);
                    }
                }

                //첫번째 2차원 배열
                var array02 = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    var contents = Console.ReadLine();
                    var rows = contents.Split(" ");
                    for (int j = 0; j < column; j++)
                    {
                        array02[i, j] = int.Parse(rows[j]);
                    }
                }


                //세번째 2차원 배열
                var array03 = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array03[i, j] = array01[i, j] + array02[i, j];
                        Console.Write(array03[i, j]);
                        if (j + 1 != column)
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i + 1 != row)
                    {
                        Console.WriteLine();
                    }
                }

            }

            void MatrixMaxValue()
            {
                var array = new int[9, 9];
                int maxValue = 0;
                var maxIndex = new int[2];
                for (int i = 0; i < 9; i++)
                {
                    var grade = Console.ReadLine();
                    var row = grade.Split(" ");
                    for (int j = 0; j < row.Length; j++)
                    {
                        var value = int.Parse(row[j]);
                        array[i, j] = value;
                        if (maxValue < value)
                        {
                            maxValue = value;
                            maxIndex[0] = i;
                            maxIndex[1] = j;
                        }
                    }
                }
                Console.WriteLine($"{maxValue}\n{maxIndex[0] + 1} {maxIndex[1] + 1}");
            }

            void ReadColumn()
            {
                var array = new string[5, 15];
                for (int i = 0; i < 5; i++)
                {
                    var grade = Console.ReadLine();
                    if (grade == null || grade.Length > 15)
                        return;
                    for (int j = 0; j < grade.Length; j++)
                    {
                        array[i, j] = $"{grade[j]}";
                    }
                }
                var answer = "";
                var a = array.GetLength(0);
                var b = array.GetLength(1);
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (array[j, i] != null)
                        {
                            answer += array[j, i];
                            //Console.WriteLine(array[j, i]);
                        }
                    }
                }
                Console.Write(answer);
            }

            void ColoredPaper()
            {
                var array = new int[100, 100];
                var squareAmount = Console.ReadLine();

                for (int i = 0; i < int.Parse(squareAmount); i++)
                {
                    var input = Console.ReadLine().Split(" ");
                    var posX = int.Parse(input[0]);
                    var posY = int.Parse(input[1]);
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            array[posX + j, posY + k]++;
                        }
                    }

                }
                int duplicatAmount = 0;
                foreach (var item in array)
                {
                    if (item > 0)
                        duplicatAmount++;
                }
                Console.WriteLine(duplicatAmount);
            }

        }

        // 일반 수학 1
        {
            void BToDecimalSystem01()
            {
                //"표현한 숫자" * ( 진법 ^자릿수)
                var intput = Console.ReadLine().Split(" ");
                var result = 0d;

                for (int i = 0; i < intput[0].Length; i++)
                {
                    var spell = intput[0][i];
                    var number = 0;
                    var parseSpell = (int.TryParse($"{spell}", out number)) ? number : spell - 55;
                    var system = int.Parse(intput[1]);
                    var pow = intput[0].Length - i - 1;
                    var temp = parseSpell * (Math.Pow(system, pow));
                    result += temp;
                }

                Console.WriteLine(result);
            }

            void BToDecimalSystem02()
            {

                var input = Console.ReadLine();
                if (input != null)
                {
                    var splitInput = input.Split(" ");


                    var inputNumber = int.Parse(splitInput[0]);
                    var system = int.Parse(splitInput[1]);
                    var array = new ArrayList();

                    while (inputNumber > 0)
                    {
                        int temp = inputNumber % system;
                        inputNumber /= system;
                        if (temp >= 10)
                        {
                            temp += 55;
                            array.Add((char)temp);
                        }
                        else
                        {
                            array.Add(temp);
                        }

                    }
                    array.Reverse();
                    foreach (var item in array)
                    {
                        Console.Write(item);
                    }


                }


            }

            void DongHyuck()
            {
                var input = Console.ReadLine();
                var testCases = new float[int.Parse(input)];
                var answer = new string[int.Parse(input)];

                // 센트와 달러의 단위를 맞춰주기위해 처음에는 testCase에0.01 를 곱했지만, 부동소수점 문제때문에 동전들에 100씩 곱해주었다.
                for (int i = 0; i < testCases.Length; i++)
                {
                    testCases[i] = float.Parse(Console.ReadLine());
                    var quarter = 0.25f * 100;
                    var dime = 0.1f * 100;
                    var nickel = 0.05f * 100;
                    var penny = 0.01f * 100;

                    var a = testCases[i] / quarter;
                    var b = (testCases[i] % quarter) / dime;
                    var c = ((testCases[i] % quarter) % dime) / nickel;
                    var d = (((testCases[i] % quarter) % dime) % nickel) / penny;

                    answer[i] = $"{(int)a} {(int)b} {(int)c} {(int)d}";
                }

                foreach (var item in answer)
                {
                    Console.WriteLine(item);
                }
            }

            void CenterMove()
            {
                var input = Console.ReadLine();

                var a = Math.Pow(2, int.Parse(input));

                var answer = (a + 1) * (a + 1);
                Console.WriteLine(answer);
            }

            void Honeycomb()
            {

                var input = int.Parse(Console.ReadLine());

                var currentNum = 1;
                var depth = 1;

                while (input > currentNum)
                {
                    currentNum += depth * 6;
                    depth++;
                }
                Console.WriteLine(depth);

            }
            void FindFraction()
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine()!);

                    var child = 1;
                    var parent = 1;

                    var capacityOrigin = 1;
                    var capacity = 1;

                    for (var index = 0; index < input; index++)
                    {
                        if (index + 1 == input)
                            Console.WriteLine($"{child}/{parent}");

                        // 한칸 이동
                        capacity--;

                        // 줄의 마지막 칸이라면.
                        if (capacity == 0)
                        {
                            //  현재 홀수줄 이라면
                            if (capacityOrigin % 2 != 0)
                            {
                                parent++;
                            }
                            // 현재 짝수줄 이라면
                            else
                            {
                                child++;
                            }

                            //줄을 바꾼다.
                            capacityOrigin++;
                            capacity = capacityOrigin;

                        }
                        //칸만 이동했다면
                        else
                        {
                            // 바꾼 이후, 현재 홀수줄 이라면
                            if (capacityOrigin % 2 != 0)
                            {
                                child--;
                                parent++;
                            }
                            // 바꾼 이후, 현재 짝수줄 이라면
                            else
                            {
                                child++;
                                parent--;
                            }
                        }

                    }



                }



            }

            void SnailMove()
            {
                while (true)
                {
                    // 무조건 밤이 낮보다 하루 적을 수 밖에 없다. 미끄러지고 난 뒤 낮에 V 에 다다르기 때문이다.
                    // 그러므로 올라야하는 높이인 V에 처음부터 하룻밤 치의 거리인 B를 빼준다.
                    var input = Console.ReadLine().Split(" ");
                    var A = int.Parse(input[0]);
                    var B = int.Parse(input[1]);
                    var V = int.Parse(input[2]);

                    var answer = (V - B) / (A - B);

                    if ((V - B) % (A - B) != 0)
                    {
                        answer++;
                    }
                    Console.WriteLine($"{answer}");
                }

            }

        }

        // 약수, 배수와 소수
        {
            void FactorMultiple()
            {
                var array = new List<int[]>();
                while (true)
                {
                    var input = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                    array.Add(input);
                    if (input[0] == 0)
                        break;
                }

                for (int i = 0; i < array.Count - 1; i++)
                {
                    if (array[i][0] % array[i][1] == 0)
                    {
                        Console.WriteLine("multiple");
                    }
                    else if (array[i][1] % array[i][0] == 0)
                    {
                        Console.WriteLine("factor");
                    }
                    else
                    {
                        Console.WriteLine("neither");
                    }
                }

            }

            void GetFactor()
            {
                var input = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                var answer = new List<int>();
                for (int i = 1; i <= input[0]; i++)
                {
                    if (input[0] % i == 0)
                    {
                        answer.Add(i);
                    }
                }
                if (answer.Count >= input[1])
                {
                    Console.WriteLine(answer[input[1] - 1]);

                }
                else
                {
                    Console.WriteLine(0);

                }
            }


            void AddFactor()
            {
                var inputs = new List<int>();
                while (true)
                {
                    var input = int.Parse(Console.ReadLine()!);
                    if (input != -1)
                    {
                        inputs.Add(input);
                    }
                    else
                    {
                        break;
                    }
                }
                for (int k = 0; k < inputs.Count; k++)
                {
                    var fators = new List<int>();
                    for (int i = 1; i < inputs[k]; i++)
                    {
                        if (inputs[k] % i == 0)
                        {
                            fators.Add(i);
                        }
                    }
                    var sum = 0;
                    foreach (var item in fators)
                    {
                        sum += item;
                    }
                    Console.Write($"{inputs[k]}");

                    if (sum == inputs[k])
                    {
                        Console.Write($" =");
                        for (int i = 0; i < fators.Count; i++)
                        {
                            Console.Write($" {fators[i]}");
                            if (i + 1 < fators.Count)
                            {
                                Console.Write($" +");
                            }
                        }
                    }
                    else
                    {
                        Console.Write($" is NOT perfect.");
                    }
                    Console.WriteLine();

                }


            }

            void FindFactor()
            {
                var playTime = int.Parse(Console.ReadLine()!);
                var array = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                var answer = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    bool isPrimeNum = false;

                    for (int j = 2; j < array[i]; j++)
                    {
                        if (array[i] % j == 0)
                        {
                            isPrimeNum = true;

                        }
                    }

                    if (array[i] != 1)
                    {
                        if (!isPrimeNum)
                        {
                            answer++;
                        }
                    }


                }
                Console.WriteLine(answer);
            }

            void Factor()
            {

                //m과 n 사이의 자연수 중 소수를 고루고ㅡ 최솟값과 이들의 합을 더함
                var M = int.Parse(Console.ReadLine()!);
                var N = int.Parse(Console.ReadLine()!);

                var answer = new List<int>();

                for (int i = M; i <= N; i++)
                {
                    bool isPrime = false;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = true;
                            break;
                        }
                    }
                    if (!isPrime && i != 1)
                        answer.Add(i);
                }
                if (answer.Count > 0)
                {
                    Console.WriteLine(answer.Sum());
                    Console.WriteLine(answer[0]);
                }
                else
                {
                    Console.WriteLine("-1");
                }

            }

            void PrimeFactorization()
            {
                var input = int.Parse(Console.ReadLine()!);

                if (input == 1)
                    return;

                bool isPrime = false;
                var num = input;

                while (!isPrime)
                {
                    isPrime = true;
                    for (int i = 2; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            num /= i;
                            isPrime = false;
                            Console.WriteLine(i);
                            break;
                        }
                    }

                }
            }

            void Eratos()
            {
                var n = int.Parse(Console.ReadLine()!);

                //배열 초기화
                bool[] c = Enumerable.Repeat<bool>(false, n).ToArray<bool>();

                //1은 소수가 아님
                c[0] = true;

                for (int i = 2; i <= n; i++)
                {
                    //위 for문이 2부터 시작하고
                    //2는 소수기 때문에 아래 if문을 바로 타도 상관 없음
                    if (c[i - 1] == false)
                    {
                        for (int j = i + i; j <= n; j = j + i)
                        {
                            //해당 소수의 배수는 모두 제거 함
                            //속도를 증가시키고 싶으면 
                            //해당 소수의 제곱 + (해당 소수 * 2) 로 하면 처리 속도가 더 빠를듯?
                            //왜냐면 현재는 for문이 돌면 중복으로 체크함
                            c[j - 1] = true;
                        }
                    }
                }
            }



        }

        // 기하: 직사각형과 삼각형
        {
            void Rectangle()
            {
                while (true)
                {
                    var input = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                    var Hansu = new Vector2(input[0], input[1]);
                    var rect = new Vector2(input[2], input[3]);


                    var distance1 = rect - Hansu;
                    var distance2 = Vector2.Zero - Hansu;
                    distance1.X = Math.Abs(distance1.X);
                    distance1.Y = Math.Abs(distance1.Y);
                    distance2.X = Math.Abs(distance2.X);
                    distance2.Y = Math.Abs(distance2.Y);

                    var shortCut1 = (distance1.X < distance1.Y) ? distance1.X : distance1.Y;
                    var shortCut2 = (distance2.X < distance2.Y) ? distance2.X : distance2.Y;

                    var answer = (shortCut1 < shortCut2) ? shortCut1 : shortCut2;

                    Console.WriteLine(Math.Abs(answer));
                }

            }

            void FourthPoint()
            {
                var points = new Vector2[3];
                for (var i = 0; i < 3; i++)
                {
                    var input = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                    points[i] = new Vector2(input[0], input[1]);
                }

                for (int i = 0; i < points.Length; i++)
                {

                    for (int j = 0; j < points.Length; j++)
                    {
                        if (i == j)
                            continue;
                        if (points[i].X == points[j].X)
                        {
                            points[i].X = 0;
                            points[j].X = 0;
                        }

                        if (points[i].Y == points[j].Y)
                        {
                            points[i].Y = 0;
                            points[j].Y = 0;
                        }
                    }
                }
                var newX = 0f;
                var newY = 0f;
                foreach (var item in points)
                {
                    if (item.X != 0)
                        newX = item.X;
                    if (item.Y != 0)
                        newY = item.Y;

                }
                Console.WriteLine($"{newX} {newY}");

            }

            void MathIsPE()
            {

                var input = long.Parse(Console.ReadLine()!);
                Console.WriteLine(4 * input);
            }

            void Ground()
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine()!);
                    if (1 <= input && input <= 100000)
                    {
                        var pointX = new int[input];
                        var pointY = new int[input];

                        for (int i = 0; i < input; i++)
                        {
                            var point = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                            pointX[i] = point[0];
                            pointY[i] = point[1];
                        }

                        var w = Math.Abs(pointX.Max() - pointX.Min());
                        var h = Math.Abs(pointY.Max() - pointY.Min());


                        Console.WriteLine(w * h);
                    }


                }


            }

            void MemoryTriangle()
            {
                var angles = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    angles[i] = int.Parse((Console.ReadLine()!));
                }
                Array.Sort(angles);

                if (angles[0] == angles[1] && angles[1] == angles[2])
                {
                    Console.WriteLine("Equilateral");
                }
                else if (angles.Sum() != 180)
                {
                    Console.WriteLine("Error");
                }
                else if (angles[0] == angles[1] || angles[1] == angles[2])
                {
                    Console.WriteLine("Isosceles");

                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }

            void TriangleThreeLine()
            {
                var Triangles = new List<string>();
                while (true)
                {
                    var triangle = Console.ReadLine()!;

                    if (triangle == "0 0 0")
                        break;

                    Triangles.Add(triangle);

                }

                foreach (var item in Triangles)
                {
                    var Lines = Array.ConvertAll(item.Split(" "), int.Parse);
                    Array.Sort(Lines);

                    if (Lines[2] >= Lines[0] + Lines[1])
                    {
                        Console.WriteLine("Invalid");
                    }
                    else if (Lines[0] == Lines[1] && Lines[1] == Lines[2])
                    {
                        Console.WriteLine("Equilateral ");
                    }

                    else if (Lines[0] == Lines[1] || Lines[1] == Lines[2])
                    {
                        Console.WriteLine("Isosceles ");
                    }
                    else if (Lines[0] != Lines[1] || Lines[1] != Lines[2])
                    {
                        Console.WriteLine("Scalene");
                    }

                }
            }

            void ThreeStick()
            {
                while (true)
                {
                    var sticks = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                    Array.Sort(sticks);
                    if (sticks[0] + sticks[1] <= sticks[2])
                    {
                        sticks[2] = sticks[0] + sticks[1] - 1;
                    }
                    Console.WriteLine(sticks.Sum());

                }

            }
        }

        // 시간 복잡도
        {

            void Lecture__1()
            {
                Console.WriteLine(1);
                Console.WriteLine(0);
            }
            void Lecture__2()
            {
                var input = Console.ReadLine()!;
                Console.WriteLine(input);
                Console.WriteLine(1);
            }
            void Lecture__3()
            {
                var input = long.Parse(Console.ReadLine()!);
                Console.WriteLine(input * input);
                Console.WriteLine(2);
            }
            void Lecture__4()
            {
                var input = long.Parse(Console.ReadLine()!);
                var answer = (input - 1) * input / 2;

                Console.WriteLine(answer);
                Console.WriteLine(2);
            }

            void Lecture__5()
            {
                var input = long.Parse(Console.ReadLine()!);
                var answer = input * input * input;

                Console.WriteLine(answer);
                Console.WriteLine(3);
            }

            void Lecture__6()
            {
                var n = long.Parse(Console.ReadLine()!);
                long sum = ((n - 2) * (n - 1) * n) / 6;

                Console.WriteLine(sum);
                Console.WriteLine(3);
            }
        }

        // 브루트 포스
        {
            void BlackJack()
            {
                while (true)
                {
                    var input1 = Console.ReadLine()!.Split(" ");
                    int N = int.Parse(input1[0]);
                    int M = int.Parse(input1[1]);
                    var input2 = Console.ReadLine()!.Split(" ");
                    var cards = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        cards[i] = int.Parse(input2[i]);
                    }

                    var answer = 0;

                    // 모든 경우의 수
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = i + 1; j < N; j++)
                        {
                            for (int k = j + 1; k < N; k++)
                            {
                                var temp = cards[i] + cards[j] + cards[k];
                                if (temp > answer && temp <= M)
                                {
                                    answer = temp;
                                    if (temp == M)
                                    {
                                        Console.WriteLine(answer);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine(answer);
                }

            }

            void DecompositionCombination()
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine()!);

                    var answer = 0;
                    for (int i = 0; i < input; i++)
                    {
                        var charArray = i.ToString().ToCharArray();

                        // 현재 i와 i의 자릿수들을 더한다.
                        var temp = i;
                        for (int j = 0; j < charArray.Length; j++)
                        {
                            temp += (int)char.GetNumericValue(charArray[j]);
                        }
                        if (temp == input)
                        {
                            answer = i;
                            break;
                        }
                    }
                    Console.WriteLine(answer);

                }
            }

            void MathIsOnlineLecture()
            {
                var Input = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

                var a = Input[0];
                var b = Input[1];
                var c = Input[2];
                var d = Input[3];
                var e = Input[4];
                var f = Input[5];

                for (int x = -999; x < 1000; x++)
                {
                    for (int y = -999; y < 1000; y++)
                    {
                        if ((a * x) + (b * y) == c && (d * x) + (e * y) == f)
                        {
                            Console.WriteLine($"{x} {y}");
                            break;
                        }
                    }

                }

            }

            void RePaintingChessBoard()
            {
                while (true)
                {
                    var input1 = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
                    var N = input1[0];
                    var M = input1[1];
                    var board = new string[N, M];
                    var answer = 64;
                    for (int i = 0; i < N; i++)
                    {
                        var input2 = Console.ReadLine()!;
                        for (int j = 0; j < M; j++)
                        {
                            board[i, j] = input2[j].ToString();
                        }
                    }

                    var tempBoards = new List<string[,]>();

                    while (tempBoards.Count <= (M - 8) * (N - 8))
                    {
                        // 시작부분의 좌표를 정해준다.
                        for (int X = 0; X <= N - 8; X++)
                        {
                            for (int Y = 0; Y <= M - 8; Y++)
                            {
                                //여기서부터 8의 크기만큼 이동하며 임시 배열에 넣어준다.
                                var tempBoard = new string[8, 8];
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 8; j++)
                                    {
                                        tempBoard[i, j] = board[i + X, j + Y];
                                    }
                                }
                                tempBoards.Add(tempBoard);
                            }
                        }
                    }

                    for (int i = 0; i < tempBoards.Count; i++)
                    {
                        var sum1 = 0;
                        var sum2 = 0;
                        for (int j = 0; j < 8; j++)
                        {
                            for (int k = 0; k < 8; k++)
                            {
                                if ((j + k) % 2 != 0)
                                {
                                    if (tempBoards[i][j, k] == tempBoards[0][0, 0])
                                    {
                                        sum1++;
                                    }
                                    else
                                    {
                                        sum2++;
                                    }

                                }
                                else
                                {
                                    if (tempBoards[i][j, k] != tempBoards[0][0, 0])
                                    {
                                        sum1++;
                                    }
                                    else
                                    {
                                        sum2++;
                                    }
                                }
                            }
                        }

                        var smallValue = (sum1 > sum2) ? sum2 : sum1;
                        if (answer > smallValue)
                        {
                            answer = smallValue;
                        }

                    }
                    Console.WriteLine(answer);
                }


            }

            void MovieDirector()
            {
                var input = int.Parse(Console.ReadLine()!);
                var num = 665;
                while (input > 0)
                {
                    num++;
                    var strNum = num.ToString();
                    for (int i = 0; i <= strNum.Length - 3; i++)
                    {
                        if ((strNum[i] == '6') && (strNum[i] == strNum[i + 1]) && (strNum[i + 1] == strNum[i + 2]))
                        {
                            input--;
                            break;
                        }
                    }
                }
                Console.WriteLine(num);

            }

            void SugarDelivery()
            {
                while (true)
                {
                    var input = long.Parse(Console.ReadLine()!);
                    var answer = 0L;

                    while (input > 0)
                    {
                        if (input % 5 == 0)
                        {
                            answer += (input / 5);
                            input = 0;
                        }
                        else
                        {
                            input -= 3;
                            answer++;
                        }

                    }
                    if (input < 0)
                        answer = -1;


                    Console.WriteLine($"{answer} ");
                }

            }

        }

        // 정렬
        {
        }

        void SortNumber()
        {
            var arraySize = int.Parse(Console.ReadLine()!);
            var inputArray = new int[arraySize];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine()!);
            }
            inputArray = QuickSort(inputArray);
            Console.WriteLine("===================");
            Console.WriteLine("최종:");

            foreach (var item in inputArray)
                Console.WriteLine(item);
        }
        void SwapItem(int[] swapArray, int left, int right)
        {
            Console.WriteLine("===================");
            Console.WriteLine($"{left}자리의{swapArray[left]} 와 {right}자리의{swapArray[right]} 위치 변경");
            Console.WriteLine();

            var temp = swapArray[left];
            swapArray[left] = swapArray[right];
            swapArray[right] = temp;
            foreach (var item in swapArray)
                Console.WriteLine(item);
        }

        int[] ArraySystemSort(int[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }

        // 선택 정렬
        // 배열에서 최소값을 찾아 맨앞과 교환한다.
        int[] SelectionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }

                }
                SwapItem(inputArray, i, minIndex);
            }
            return inputArray;
        }

        // 삽입정렬
        // 1부터 위치를 옮겨가며 해당 위치에있는것보다 앞에있는것이 크다면 위치를 바꾼다.
        int[] InsertionSort(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (inputArray[i] < inputArray[j])
                    {
                        SwapItem(inputArray, i, j);
                    }

                }
            }
            return inputArray;
        }

        // 퀵정렬
        // 피벗을 기준으로 작은요소는 왼쪽, 큰요소는 오른쪽으로 분할함. 각 분할된 부분에서 피벗을 정해서 반복함.
        int[] QuickSort(int[] inputArray)
        {
            Quick_QuickSort(inputArray, 0, inputArray.Length - 1);
            return inputArray;
        }
        
        void Quick_QuickSort(int[] inputArray, int left, int right)
        {
            var pivot = left;
            var low = left + 1;
            var high = right;

            while (low <= high)
            {
                if (inputArray[low] < inputArray[pivot])
                {
                    low++;
                    continue;
                }

                if (inputArray[pivot] < inputArray[high])
                {
                    high--;
                    continue;
                }

                if (low < high)
                {
                    SwapItem(inputArray, low, high);
                }
            }
            if (left < right)
            {
                SwapItem(inputArray, pivot, high);
                Quick_QuickSort(inputArray, left, high - 1);
                Quick_QuickSort(inputArray, high + 1, right);
            }
        }

      
    }




}