﻿namespace Stealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAccessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }
}
