int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int elemetsToPush = input[0];
int elemetsToPop = input[1];
int number = input[2];

Queue<int> stack = new();

for (int i = 0; i < elemetsToPush; i++)
{
    stack.Enqueue(numbers[i]);

}

for (int i = 0; i < elemetsToPop; i++)
{
    stack.Dequeue();
}

if (stack.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}






