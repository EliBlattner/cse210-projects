using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    static void Main(string[] args)
    {
        string userLoopInput = "999";

        //Write class operations below
        Write write1 = new Write();
        write1._userEntry = Console.ReadLine();
        write1._currentDateTime = DateTime.Now;

        Show show1 = new Show();
        show1._entriesList.Add(write1.Display());

        while (userLoopInput != "0"); 
        {
            Console.WriteLine("Please enter an Input from 1-5.\n1. Write\n2. Show\n3. Save\n4. Load\n5. Quit");
            
            if (userLoopInput == "1");
            {

            }

            else i
        }


    }
}