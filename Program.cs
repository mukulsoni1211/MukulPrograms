using System;
using System.Diagnostics;


namespace MyUtilities // custom namespace
{
    public class Greetings
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name} from MyUtilities namespace!");
        }
    }
}

class Mukul
{
    static void Main(string[] args)
    {
        Console.WriteLine("Runing the first Program");
        Console.Write("Entre your age:- ");
        var inputAge = Console.ReadLine();
        var age = 0;
        //If else and TRY CATCH And GET INPUT
         #region
            try
            {
                age = Convert.ToInt32(inputAge);
                Console.WriteLine($"Received age is {age}");

                if (age < 20)
                {
                    Console.WriteLine("You are too young to vote.");
                }
                else if (age >= 20 && age < 30)
                {
                    Console.WriteLine("You are eligible to vote.");
                }
                else
                {
                    Console.WriteLine("You are too old to vote.");
                };
                
            }
            catch (Exception e)
            {
                Console.WriteLine("TRY AGAIN, Please provide only numbers");
            }
            finally
            {
                Console.WriteLine("Successed");
            }
            

            //switch cases
            var name = "Mukul";
            switch (name)
            {
            case "Mukul":
                 Console.WriteLine("Hello Mukul");
                break;
            case "Soni":
                Console.WriteLine("Hello Soni");
                break;
            }
        #endregion

        // const and enums
        # region
        #endregion
        var a = new MyUtilities.Greetings();
        a.SayHello("TESTERs");
        Console.WriteLine($"Received age is {age}");
    }
}