// See https://aka.ms/new-console-template for more information


public class Class1
{
	public Class1()
	{
        var input = Console.ReadLine() as string;
        var A = int.Parse(input.Split(" ")[0]);
        var B = int.Parse(input.Split(" ")[1]);
        Console.WriteLine(A + B);

    }
}
