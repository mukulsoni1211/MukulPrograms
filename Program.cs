using System;
class Mukul
{
    static void Main(string[] args)
    {
        Console.WriteLine("Runing the first Program");
        Console.Write("Entre your age:- ");
        var inputAge = Console.ReadLine();
        var age = 0;
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

        Console.WriteLine($"Received age is {age}");
    }
}