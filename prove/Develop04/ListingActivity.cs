
using System.Net;

public class ListingActivity : Activity
{
    //LISTING PROGRAM HERE
    private string _userReady = "empty";
    List<string> _promptTopic3 = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    List<string> _userResponses = new List<string>();
    public ListingActivity()
    {
        Console.WriteLine("Get ready...\n");
        base.SpinningWheel();

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: \n");

        //Creates random index to take a random prompt from the prompt list. Happens each time
        //a new Reflecting Activity object is created.
        Random random1 = new Random();

        int randomIndex = random1.Next(_promptTopic3.Count);
        string randomItem = _promptTopic3[randomIndex];

        Console.WriteLine($" --- {randomItem} --- \n");
    }

    public void ListingExcercise(int countdown)
    {
        while (_userReady != "")
        {
            Console.WriteLine("When you are ready to start listing, press enter.");
            _userReady = Console.ReadLine();
        }

        Console.WriteLine($"Get ready to list as many responses as you can: \n");
        SpinningWheel();
        Console.Clear();

        //DateTime logic
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(countdown);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            _userResponses.Add(userInput);
        }

        int responseAmount = _userResponses.Count;
        Console.WriteLine($"\nGreat work! You listed {responseAmount} items!");
        SpinningWheel();

    }
}