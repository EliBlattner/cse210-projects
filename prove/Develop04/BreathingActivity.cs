
using System.Reflection.PortableExecutable;

public class BreathingActivity : Activity
{
    //BREATHING PROGRAM HERE

    private int _breathLength = 5;

    public BreathingActivity()
    {
        Console.WriteLine($"\nGet Ready...");
        base.SpinningWheel();
        Console.Clear();
    }

    //Displays the Breathing Activity as many times as can fit
    //within the time limit the user gives
    public void BreathingExcercise(int countdown)
    {
        int breathCycles = countdown / 10;
        
        //In case the user chooses a time too short
        if (breathCycles < 1)
        {
            breathCycles = 1;
        }

        for (int i = breathCycles ; i > 0; i--)
        {  
            Console.Write("\nBreathe in...");
            
            base.DescendingCountdownWait(_breathLength);
            Console.Write(" \b");
            
            Console.Write("\nNow breathe out...");
            
            base.DescendingCountdownWait(_breathLength);
            Console.Write(" \b\n");
        }
    }
}