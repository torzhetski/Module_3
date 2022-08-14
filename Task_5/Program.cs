class Program
{
    static void Main()
    {
        Console.WriteLine("Hellow, lets start the game!\nEnter the Max value of number subsequence");
        int max = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int numberToGuess= random.Next(max);
        int number;
        Console.WriteLine("Now try to guess this number! and if you bored tap enter to end the game");
        while (true)
        {
            string numberCheck = Console.ReadLine();
            if (numberCheck == "") break;
            else  number = Convert.ToInt32(numberCheck);
            if (number > numberToGuess) Console.WriteLine("Entered nuber is larger than guessed");
            else Console.WriteLine("Entered number is less than guessed");
            if (number == numberToGuess) Console.WriteLine("Exellent, you guessed the number ");
        }
    }
}