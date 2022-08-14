class Program
{
    static void Main()
    {
        int min = int.MaxValue;
        Console.WriteLine("enter the lenght of your subsequence");
        int lenght =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter numbers");
        for(int i = 0; i < lenght; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());  
            if(value < min) min = value;
        }
        Console.WriteLine($"Min value is {min}");
    }
}