using System.Collections;

namespace Car;
class Program
{
    class Cars : CustomColor
    {
        public string engineSize;
        public int tyreSize;
        public string systemType;

        public Cars ()
        {
            this.engineSize = "";
            this.tyreSize = 0;
            this.systemType = "";

        }

        public void EngineV1()
        {
            Console.WriteLine("Engine Type is V.4 Engine");
        }

        public void EngineV2()
        {
            Console.WriteLine("Engine Type is V.6 Engine");
        }
        public void Tyre1()
        {
            Console.WriteLine("Tyre Type are Low Profile Tyre");
        }
        public void SoundSystem()
        {
            Console.WriteLine("Sound System Type is Bose ");
        }



        public void color(string c)
        {
            
            Console.WriteLine("The color is {0}", c);
        }
    }

    interface CustomColor
    {
        void color(string c);

    }
       

    


    static void Main(string[] args)
    {
        Cars Dodge = new Cars();
        Console.WriteLine("This is a Dodge");
        Dodge.EngineV2();
        Dodge.Tyre1();
        Dodge.SoundSystem();
        Dodge.color("Black");

        
    }
}

