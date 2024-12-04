using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace BlakeHunt_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro");
            Console.Read();
            Console.Clear();

            //AddNode();

            bool ween = true;
            while (ween)
            {
                string input = Console.ReadLine();
                //dont use "A" or "I" for controls.
                if (input == "`")
                {
                    ween = false;
                }
            }
        }
    }
}
