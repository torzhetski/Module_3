class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("tap 0 to exit, tap 1 to enter number");
            int key = Convert.ToInt32(Console.ReadLine()); //int key = int.Parse(Console.ReadLine);
            if (key == 0) break;
            else
            {
                Console.WriteLine("enter your number");
                int number = Convert.ToInt32(Console.ReadLine());  //int number = int.Parse(Console.ReadLine);
                if (number % 2 == 0)
                    Console.WriteLine("your number is even");
                else
                    Console.WriteLine("your number is odd");
            }
        }
    }
}