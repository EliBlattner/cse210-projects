public class SaveAndLoad
{

    public void SaveCurrentEntries()
    {
        Console.WriteLine("What is the name of the file you'd like to save to?: ");
        string fileName = Console.ReadLine();

        //Save to file.
        //(Write entries in userGoalsList onto the txt file.)
    }
    

    public void LoadEntriesFromFile()
    {
        Console.WriteLine("What is the name of the file you'd like to load entries from?: ");
        string fileName = Console.ReadLine();

        //Load entries from a file.
        //(Reassign entries of userGoalsList with entries from txt file.)
    }
}