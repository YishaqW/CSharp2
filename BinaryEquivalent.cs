namespace BinaryEquivalent;
class Program
{
    static void Main(string[] args)
    {
        string n;

        Console.Write("Enter number to find Binary Equivalent: ");
        n = Console.ReadLine();

        Console.WriteLine("\nThe binary equivalent of {0} is: {1}", n, binary(n));

    }

    public static string binary(string n)
    {
        int digit, num;
        string result = "";
        num = Convert.ToInt32(n);

        while ( num > 0)
        {
            digit = num % 2;
            num /= 2;
            result = digit.ToString() + result;

            // Console.WriteLine(result);
        }

        return result;
    }
}

