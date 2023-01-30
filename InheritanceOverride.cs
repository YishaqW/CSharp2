namespace InheritanceOverride;
class Program
{
    class CityBaseClass
    {
        public string town=" ";

        public virtual string cityName()
        {

            town = Convert.ToString("The city capital is unknown.");
            return town;
            
        }
    }

    class CityDerivedClass : CityBaseClass
    {
        

        public override string cityName()
        {

            town = Convert.ToString("The city captial is the most popular spot.");
            return town;
        }
    }
    static void Main(string[] args)
    {
        // call method

        Console.WriteLine("{0}", cityName(""));
    }

    public static string cityName(string c)
    {
        string city=" ";

        CityDerivedClass cityDerived = new CityDerivedClass();
        city = cityDerived.cityName();

        
        return city;
    }
}

