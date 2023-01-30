namespace Diamond;
class Program
{
    static void Main(string[] args)
    {
        int row = 5, i, j, count=1;
        count = row - 1;
        for(i =1; i <= row; i++)
        {
            for (j=1;j <= count; j++)
            
                Console.Write(" ");
            
             count--;
            for (j = 1;j <= 2*i-1;j++)
            
                Console.Write("*");
            
            Console.WriteLine("\n");
        }

        count = 1;
        for (i = 1; i <= row -1; i++)
        {
            for (j = 1; j <= count; j++)
            
                Console.Write(" ");
            
            count++;
            for (j = 1; j <= 2 * (row - i)-1; j++)
            
                Console.Write("*");
            
            Console.WriteLine("\n");
        }

    }
}

cd