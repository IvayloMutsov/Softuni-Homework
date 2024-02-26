Console.ForegroundColor = ConsoleColor.DarkGreen;
Queue<int> nums = new Queue<int> ();
string input = Console.ReadLine();
int[] numbers = input.Split(" ").Select(int.Parse).ToArray();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        nums.Enqueue(numbers[i]);
    }
}
Console.WriteLine(string.Join(", ", nums));