class Program
{
    static void Main()
    {
        Console.WriteLine("Hellow, lets start: enter amount of your cards");
        int Sum = 0;
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your card rating where:\n2-10 for cards from 2 till 10 and J for Jack, Q for Queen, K for King and A for Ace");
        for (int i = 0; i < amount; i++)
        {
            string rating = Console.ReadLine();
            if (rating == "J" || rating == "Q" || rating == "K" || rating == "A")
                Sum += 10;
            else
                Sum +=Convert.ToInt32(rating);
        }
        Console.WriteLine($"your card sum is {Sum}");
    } 
}


