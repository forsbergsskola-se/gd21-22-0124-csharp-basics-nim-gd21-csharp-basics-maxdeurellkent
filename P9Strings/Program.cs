namespace Strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your first name?");
            string nameFirst = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string nameLast = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + nameFirst + " " + nameLast + ", you are " + age + " years old!");
            
        }
    }
}

