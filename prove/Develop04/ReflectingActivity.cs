
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    //REFLECTING PROGRAM HERE
    private string _userGoAhead = "empty";

    List<string> _promptTopic1 = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    List<string> _questionsList1 = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind for the future?"};

    public ReflectingActivity()
    {
        Console.WriteLine("Get ready...\n");
        base.SpinningWheel();

        Console.Clear();
        Console.WriteLine("Consider the following prompt: \n");

        //Creates random index to take a random prompt from the prompt list. Happens each time
        //a new Reflecting Activity object is created.
        Random random1 = new Random();

        int randomIndex = random1.Next(_promptTopic1.Count);
        string randomItem = _promptTopic1[randomIndex];

        Console.WriteLine($" --- {randomItem} --- \n");
    }

    public void ReflectingExcercise(int countdown)
    {
        while (_userGoAhead != "")
        {
            Console.WriteLine("When you have something in mind, press enter to continue.");
            _userGoAhead = Console.ReadLine();
        }

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. You may begin in: \n");
        DescendingCountdownWait(5);
        Console.Clear();

        int promptCount = countdown / 15;

        if (promptCount < 1)
        {
            promptCount = 1;
        }

        for (int i = promptCount ; i > 0; i--)
        {
            //Creates random prompt index to be used for _questionsList1
            Random random2 = new Random();

            int randomIndex = random2.Next(_questionsList1.Count);
            string randomItem = _questionsList1[randomIndex];


            Console.Write($"\n > {randomItem} ");
            base.SpinningWheel(); base.SpinningWheel(); base.SpinningWheel(); base.SpinningWheel(); base.SpinningWheel();
        }
    } 
}