namespace IfElse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            
            if (ageNum <= 12 & ageNum >= 0) Console.WriteLine("You are a child");
            else if (ageNum <= 19 & ageNum >= 13) Console.WriteLine("You are a teenager");
            else Console.WriteLine("You are a grown-up");

            Console.WriteLine("Give me another integer.");
            string numString = Console.ReadLine();
            int num = Convert.ToInt32(numString);

            int max = Math.Max(num, ageNum);
            Console.WriteLine("The biggest number out of your age and the number you entered is: " + max);
            
            //using the ternary operator isntead of if else here
            Console.WriteLine(max % 2 != 0 ? "The number you entered is odd" : "The number you entered is even");
            
            // if (max % 2 != 0) Console.WriteLine("The number you entered is odd");
            // else Console.WriteLine("The number you entered is even");
            
            

        }
    }
}

