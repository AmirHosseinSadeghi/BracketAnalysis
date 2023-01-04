using BracketAnalysis;
Console.WriteLine("Please Enter the Brackets");
Solution solution = new Solution();
while (true)
{
    string str = Console.ReadLine();
    if (solution.IsBracket(str))
    {
        Console.WriteLine($"Input : {str}\r\nOutput : {solution.IsValid(str)}");
        Console.WriteLine("Please Enter New the Brackets");
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Please Enter Jut Brackets");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
