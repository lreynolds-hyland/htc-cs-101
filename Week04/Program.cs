using System;

namespace Week04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool snowing = true;
            bool haveCarrot = true;
            int temp = 40;
            string clothes = "outfit";
            string name = "Lucas";

            if ((snowing && temp <= 40) && (name != "Bob" || haveCarrot)) {
                Console.WriteLine("I'm a snowman!");
            }
        }
    }
}
