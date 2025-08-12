using System;
using System.Diagnostics;

namespace CustomClass
{
    public class Tester
    {
       public int Id { get; set; }
       public string Name { get; set; }

    };

    public class SayWord
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Custom class class!");
        }
    }
};
