namespace Workshop
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();
            Console.WriteLine($"THE SUM OF DIGIT IS : {sum} ");
            Console.ReadKey();
        }
    }
}