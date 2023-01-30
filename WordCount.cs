namespace WordCount;
class Program
{
    static void Main(string[] args)
    {

        string str;
        int len,word =1, counter=0;

        Console.WriteLine("Please input your string: ");
        str = Console.ReadLine();

        len = str.Length;

        while (counter < len)
        {
            if (str[counter]==' ' || str[counter]==',')
            {
                word++;
            }
            counter++;
        }

        Console.WriteLine("Word count of string is: {0}", word);



    }
}

