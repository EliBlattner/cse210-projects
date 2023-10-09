using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    static void Main(string[] args)
    {
        string userLoopInput = "0";

        //Write class operations below
        Write write1 = new Write();

        while (userLoopInput != "5")
        {
            Console.WriteLine("Please enter an Input from 1-5.\n1. Write\n2. Show\n3. Save\n4. Load\n5. Quit");
            Console.WriteLine("What is your input?: ");
            userLoopInput = Console.ReadLine();


            if (userLoopInput == "1")
            {   
                write1.Display2();
                write1._userEntry = Console.ReadLine();
                write1._currentDateTime = DateTime.Now;
                //ADD this to a list to keep it
                
                write1._entriesList.Add(write1.Display());
            }

            else if (userLoopInput == "2")
            {
                Console.WriteLine("\n---------------\nJournal Entries\n---------------\n");
                
                 for (int i = 0; i < write1._entriesList.Count; i++)
                    {
                        Console.WriteLine($"{write1._entriesList[i]}\n");
                    }
            }

            else if (userLoopInput == "3")
            {
                Console.WriteLine("Save Call");
            }

            else
            {
                Console.WriteLine("Load Call");
            }
        }


    }
}