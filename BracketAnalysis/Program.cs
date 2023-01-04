using BracketAnalysis;

Solution solution = new Solution();
while (true)
{
    Console.WriteLine("Please Enter the Brackets");
    string str = Console.ReadLine();
    Console.WriteLine($"Input : {str}\r\nOutput : {solution.IsValid(str)}");
}
