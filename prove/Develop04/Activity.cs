
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

public class Activity
{
    private string _activityType;
    private int _desiredDuration = 5;

    List<string> _wheelCharacters = new List<string> { "-", "\\", "|", "/" };

    //SHARED SUB CLASS COMMONALITIES HERE (PARENT CLASS)

    //Wheel that spins for 5 seconds, to be inserted as needed in other code.
    public string SpinningWheel()
    {
        
        
        return 
    }
    

    //Counts down from 5 to 1 at default, and takes parameter when user needs a 
    //higher countdown timer.
    public void DescendingCountdownWait(int _desiredDuration)
    {
        for (int i = _desiredDuration ; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
        Console.WriteLine("Done");
    }

    public void StartupMessage(string _activityType)
    {
        string introMessage = "null";

        if (_activityType == "Breathing")
        {
            introMessage = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        
        
        Console.WriteLine($"Welcome to the {_activityType} activity.")

    }


    public string EndMessage(_activityType)
    {
        return
    }
}