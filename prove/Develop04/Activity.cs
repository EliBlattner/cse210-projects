using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

public class Activity
{
    private int _desiredDuration;
    List<string> _wheelCharacters = new List<string> { "-", "\\", "|", "/" };

    //SHARED SUB CLASS COMMONALITIES HERE (PARENT CLASS)

    //Wheel that spins for 5 seconds, to be inserted as needed in other code.
    public void SpinningWheel()
    {
        foreach (string animation in _wheelCharacters)
        {
            Console.Write(animation);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    

    //Counts down from 5 to 1 at default, and takes parameter when user needs a 
    //higher countdown timer.
    public void DescendingCountdownWait(int _desiredDuration)
    {
        for (int i = _desiredDuration ; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i < 9)
            {
                Console.Write("\b");
            }
            else
            {
                Console.Write("\b\b");
            }
        }
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
        else if (_activityType == "Attributes")
        {
            introMessage = "This activity will help you observe how your body and environment around you attribute to your feelings.";
        }
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_activityType} activity. \n\n{introMessage}\n\nHow long in seconds, would you like for your session?:");
        string userChoiceDurationString = Console.ReadLine();
        int userChoiceDuration = int.Parse(userChoiceDurationString);

        _desiredDuration = userChoiceDuration;

    }

    public void EndMessage(string _activityType)
    {
        Console.Clear();
        Console.WriteLine($"\n\nWell Done!");
        SpinningWheel();
        Console.WriteLine($"\n\nYou have completed another {_desiredDuration} seconds of the {_activityType} Activity.");
        SpinningWheel();
    }

    public int PassCountdown()
    {
        return _desiredDuration;
    }
}