namespace Random
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give me a seed (integer)");
            string seedString = Console.ReadLine();
            int seed = Convert.ToInt32(seedString);
            System.Random random = new System.Random(seed);
            
            Console.WriteLine("Three integers between 0 and 5");
            Console.WriteLine(random.Next(0,5));
            Console.WriteLine(random.Next(0,5));
            Console.WriteLine(random.Next(0,5));

            Console.WriteLine("Three numbers between 0.0 and 0.5");
            Console.WriteLine(random.NextDouble()*0.5);
            Console.WriteLine(random.NextDouble()*0.5);
            Console.WriteLine(random.NextDouble()*0.5);

            Console.WriteLine("Three numbers between 0.2 and 0.7");
            Console.WriteLine(random.NextDouble()*0.5 + 0.2);
            Console.WriteLine(random.NextDouble()*0.5 + 0.2);
            Console.WriteLine(random.NextDouble()*0.5 + 0.2);
            

            Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
            string critChanceString = Console.ReadLine();
            float critChance = Convert.ToSingle(critChanceString);

            //would be nice to use a loop here :) and maybe even above
            
            string hit = random.NextDouble() <= critChance ? "Crit" : "No Crit";
            Console.WriteLine(hit);
            
            hit = random.NextDouble() <= critChance ? "Crit" : "No Crit";
            Console.WriteLine(hit);
            
            hit = random.NextDouble() <= critChance ? "Crit" : "No Crit";
            Console.WriteLine(hit);
            
            hit = random.NextDouble() <= critChance ? "Crit" : "No Crit";
            Console.WriteLine(hit);
            
            hit = random.NextDouble() <= critChance ? "Crit" : "No Crit";
            Console.WriteLine(hit);
        }
    }
}

