namespace VowelAndConstantCount;
class Program
{
    static void Main(string[] args)
    {
        string str;
        int length, v=0, c=0;

        Console.WriteLine("Enter string: ");
        str = Console.ReadLine();

        length = str.Length;

        for (int i = 0; i < length; i++){

            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                str[i] == 'O' || str[i] == 'U')
            {
                v++;
            }
            else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                c++;
            }
        }
        Console.WriteLine("Total number of vowels: {0}", v);
        Console.WriteLine("Total number of constants: {0}", c);
    }
}

