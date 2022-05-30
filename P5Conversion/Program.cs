namespace Conversions
{
    class Program
    {
        static void Main()
        {
            int number = 5;
            
            string numberString = Convert.ToString(number);

            Console.WriteLine(numberString);

            numberString = "56,3";

            number = (int) Math.Round(Convert.ToSingle(numberString));

            Console.WriteLine(number);
        }
    }
}


