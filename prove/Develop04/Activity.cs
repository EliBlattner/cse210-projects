
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

public class Activity
{
    private int _desiredDuration = 5;

    List<string> _wheelCharacters = new List<string> { "-", "\\", "|", "/" };

    //SHARED SUB CLASS COMMONALITIES HERE (PARENT CLASS)

    //Wheel that spins for 5 seconds, to be inserted as needed in other code.
    public void SpinningWheel()
    {
        foreach (string animation in _wheelCharacters)
        {
            Console.WriteLine(animation);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    

    //Counts down from 5 to 1 at default, and takes parameter when user needs a 
    //higher countdown timer.
    public void DescendingCountdownWait()
    {
        for (int i = _desiredDuration ; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
        Console.WriteLine("Done");
    }

    //Displays a startup message based on several instance fields
    public void StartupMessage(string _activityType)
    {
        string introMessage = "null";

        if (_activityType == "Breathing")
        {
            introMessage = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else if (_activityType == "Reflecting")
        {
            introMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_activityType == "Listing")
        {
            introMessage = "This activty will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        
        Console.WriteLine($"Welcome to the {_activityType} activity. \n\n{introMessage}\n\nHow long in seconds, would you like for your session?:");
        string userChoiceDurationString = Console.ReadLine();
        int userChoiceDuration = int.Parse(userChoiceDurationString);

        _desiredDuration = userChoiceDuration;

    }


    public void EndMessage(string _activityType)
    {

        Console.WriteLine($"\n\nWell Done!\n\nYou have completed another {_desiredDuration} seconds of the {_activityType} Activity.");

    }
}