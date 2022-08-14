class Program
{
    static void Main()
    {
        Console.WriteLine("enter your number");
        int number = Convert.ToInt32(Console.ReadLine());
        bool flag = true;
        int key = number-1;
        while(key!=1)
        {
            if (number % key == 0) flag = false;
            key--;
        }
        if (flag) Console.WriteLine("your number is prime");
        else Console.WriteLine("your number is not prime");
    }
}