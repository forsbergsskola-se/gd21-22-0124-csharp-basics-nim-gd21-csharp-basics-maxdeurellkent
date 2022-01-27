namespace Booleans
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);

            bool isChild = ageNum <= 12 & ageNum >= 0;
            Console.WriteLine("You are a child:"+ isChild);
            
            bool isTeenager = ageNum <= 19 & ageNum >= 13;
            Console.WriteLine("You are a teenager:"+ isTeenager);

            bool isGrownup = ageNum > 19;
            Console.WriteLine("You are a grown-up:"+ isGrownup);
        }
    }
}

