namespace Math
{
    class program
    {
        static void Main()
        {
            
            Console.WriteLine("Give me your first number.");
            string firstString = Console.ReadLine();
         
            Console.WriteLine("Give me your second number.");
            string secondString = Console.ReadLine();
            double first = Convert.ToDouble(firstString);
            double second = Convert.ToDouble(secondString);
         
            Console.WriteLine("Max:");
            double max = System.Math.Max(first,second);
            Console.WriteLine(max);
          
            Console.WriteLine("Min:");
            double min = System.Math.Min(first, second);
            Console.WriteLine(min);
          
            Console.WriteLine("Sqrt:");
            double sqrt1 = System.Math.Sqrt(first);
            double sqrt2 = System.Math.Sqrt(second);
            Console.Write("First number ");
            Console.WriteLine(sqrt1);
            Console.Write("Second number ");
            Console.WriteLine(sqrt2);
         
            Console.WriteLine("Abs:");
            double abs1 = System.Math.Abs(-first);
            double abs2 = System.Math.Abs(-second);
            Console.Write("First number ");
            Console.WriteLine(abs1);
            Console.Write("Second number ");
            Console.WriteLine(abs2);
         
            Console.WriteLine("Round:");
            double round1 = System.Math.Round(first);
            double round2 = System.Math.Round(second);
            Console.Write("First number ");
            Console.WriteLine(round1);
            Console.Write("Second number ");
            Console.WriteLine(round2);
          
            Console.WriteLine("Floor:");
            double floor1 = System.Math.Floor(first);
            double floor2 = System.Math.Floor(second);
            Console.Write("First number ");
            Console.WriteLine(floor1);
            Console.Write("Second number ");
            Console.WriteLine(floor2);
           
            Console.WriteLine("Ceil:");
            double ceil1 = System.Math.Ceiling(first);
            double ceil2 = System.Math.Ceiling(second);
            Console.Write("First number ");
            Console.WriteLine(ceil1);
            Console.Write("Second number ");
            Console.WriteLine(ceil2);
           
            Console.WriteLine("Clamp:");
            double clamp1 = System.Math.Clamp(first, 1, 5);
            double clamp2 = System.Math.Clamp(second, 1, 5);
            Console.Write("First number ");
            Console.WriteLine(clamp1);
            Console.Write("Second number ");
            Console.WriteLine(clamp2);
            
            Console.WriteLine("Pow:");
            double pow = System.Math.Pow(first, second);
            Console.WriteLine(first + " to the power of " + second + " is " + pow);
        }
    }
}


