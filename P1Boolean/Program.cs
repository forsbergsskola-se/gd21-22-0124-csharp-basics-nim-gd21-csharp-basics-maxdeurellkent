namespace Booleans
{
    class Program
    {
        static void Main()
        {
            bool isChild;
            bool isTeenager;
            bool isGrownup;
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            
            if (ageNum <= 12 & ageNum >= 0) isChild = true;
            else isChild = false;
            Console.WriteLine("You are a child:" + isChild);
            
            if (ageNum <= 19 & ageNum >= 13) isTeenager = true;
            else isTeenager = false;
            Console.WriteLine("You are a teenager:" + isTeenager);

            if (ageNum > 19) isGrownup = true;
            else isGrownup = false;
            Console.WriteLine("You are a grown-up:" + isGrownup);
        }
    }
}

