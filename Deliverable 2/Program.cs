using System;

namespace Deliverable
{
    class Program
    {
        static void Main(string[] arg)
        {
            bool shutdown = false;
            bool foundresponse = false;
            string inputvalue;
            string outputvalue = "";

            Console.WriteLine("What would you like to say to the Bot?");





            while (!shutdown)
            {
                foundresponse = false;

                Console.Write("");
                inputvalue = Console.ReadLine().ToLower();

                Console.WriteLine("Bot: ");


                switch (inputvalue)
                {
                    case "hello":
                        outputvalue = "What else would you like to say to the Bot?";
                        Console.WriteLine("Hi good to see you");
                        foundresponse = true;
                        break;


                    case "bye":
                        outputvalue = "Good bye";
                        shutdown = true;
                        break;

                    case "sup":
                        outputvalue = "What else would you like to say to the Bot?";
                        Console.WriteLine("I am good");
                        foundresponse = true;
                        break;


                    case "hello there":
                        outputvalue = "What else would you like to say to the Bot?";
                        Console.WriteLine("General kenobi");
                        foundresponse = true;
                        break;
                }
                if (foundresponse)
                {
                    Console.WriteLine(outputvalue);
                }
                else
                {
                    Console.WriteLine("");
                }
                if (shutdown)

                {
                    Console.WriteLine("Good bye");
                }




            }
        }
    }
}
