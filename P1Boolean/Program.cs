namespace Booleans
{
    class Program
    {
        static void Main()
        {
            //bool isChild;
            //bool isTeenager;
            //bool isGrownup;
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            
            // if (ageNum <= 12 & ageNum >= 0) isChild = true;
            // else isChild = false;
            // Console.WriteLine("You are a child:" + isChild);
            string answer1 = ageNum <= 12 & ageNum >= 0 ? "You are a child" : "You are not a child";
            Console.WriteLine(answer1);
            
            //if (ageNum <= 19 & ageNum >= 13) isTeenager = true;
            //else isTeenager = false;
            //Console.WriteLine("You are a teenager:" + isTeenager);
            string answer2 = ageNum <= 19 & ageNum >= 13 ? "You are a teenager" : "You are not a teenager";
            Console.WriteLine(answer2);
            

            //  if (ageNum > 19) isGrownup = true;
            //  else isGrownup = false;
            //  Console.WriteLine("You are a grown-up:" + isGrownup);
            string answer3 = ageNum > 19 ? "You are an adult" : "You are not an adult";
            Console.WriteLine(answer3);
          
        }
    }
}

