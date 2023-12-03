public class AttributesActivity : Activity
{
    //LISTING PROGRAM HERE
    private string _userReady = "empty";
    List<string> _promptTopic3 = new List<string> {"What can you hear around you?", "What parts of your body can you feel sensations in?", "How does your body react when you take long, deep breaths?"};

    List<string> _userResponses = new List<string>();
    public AttributesActivity()
    {
        Console.WriteLine("Get ready...\n");
        base.SpinningWheel();

        Console.Clear();
        Console.WriteLine("Record any thoughts that enter your mind given the propmt: \n");

        //Creates random index to take a random prompt from the prompt list. Happens each time
        //a new Reflecting Activity object is created.
        Random random1 = new Random();

        int randomIndex = random1.Next(_promptTopic3.Count);
        string randomItem = _promptTopic3[randomIndex];

        Console.WriteLine($" -=-=- {randomItem} -=-=- \n");
    }

    public void AttributesExcercise(int countdown)
    {
        while (_userReady != "")
        {
            Console.WriteLine("Remember to relax your body. Press enter when ready. ");
            _userReady = Console.ReadLine();
        }

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
        Console.WriteLine($"\nThank you for recording your thoughts today.");
        SpinningWheel();

    }
}