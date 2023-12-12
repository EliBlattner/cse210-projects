public class SaveAndLoad
{
    private string _fileName;

    public void SetFileName()
    {
        Console.WriteLine("What is full name of the txt file you'd like to access?\n");
        _fileName = Console.ReadLine();
    }

    public void SaveCurrentEntries(List<string> userGoalList)
    {
        Console.WriteLine("Would you like to: \n\n1. Add the goals fromm your current session to the txt file\n2. Overwrite existing goals on the txt file with this sessions's progress.\n");
        string userContinueChoice = Console.ReadLine();

        if (userContinueChoice == "1")
        {    
            using StreamWriter writer = new StreamWriter(_fileName);
            {
                foreach (string entry in userGoalList)
                {
                    writer.WriteLine(entry);
                }
            }
        }
        else if (userContinueChoice == "2")
        {
            File.WriteAllText(_fileName, string.Empty);
            
            using StreamWriter writer = new StreamWriter(_fileName);
            {
                foreach (string entry in userGoalList)
                {
                    writer.WriteLine(entry);
                }
            }
        }
        //Save to file.
        //(Write entries in userGoalsList onto the txt file.)
    }
    

    public void LoadEntriesFromFile(List<string> userGoalList)
    {
        Console.WriteLine("Warning! This will erase all progress from current session (if any). \nWould you like to continue? (y/n): \n");
        string userContinueChoice = Console.ReadLine();

        if (userContinueChoice == "y")
        {
            // Use StreamReader to read the contents of the file
            using (StreamReader reader = new StreamReader(_fileName))
            {
                // Clear existing entries in userGoalList
                userGoalList.Clear();
                // Read each line from the file and add it to userGoalList
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    userGoalList.Add(line);
                }
            }
        }
        else if (userContinueChoice == "n")
        {
            // Handle the case when the user chooses not to load
        }
        else
        {
            Console.WriteLine("Invalid input. Please return 'y' or 'n'.");
        }
        //Load entries from a file.
        //(Reassign entries of userGoalsList with entries from txt file.)
    }
}