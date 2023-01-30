namespace SumOfIndividualDigits;
class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.Write("Find the sume of numbers entered.\nEnter numbers: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe sum of the digits {0} are: {1}", num, sumDigits(num));


    }

    public static int sumDigits(int n)
    {
        int sum;

        for (sum = 0; n > 0; sum = sum + n % 10, n = n / 10) ;

        return sum;
    }
}
