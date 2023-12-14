using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected static List<string> userGoalList = new List<string>();
    protected int _pointsTotal = 0;
    private List<string> _displayedGoalTypeList = new List<string>();
    

    //virtual method is default for SimpleGoal class.
    public virtual void CreateNewGoal()
    {
        Console.WriteLine("What is the name of the goal?: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?: ");
        string goalDescrip = Console.ReadLine();
        Console.WriteLine("What is the point value of the goal?: ");
        int goalPointVal = int.Parse(Console.ReadLine());
        bool completionBool = false;

        string SimpleParseableString = $"SimpleGoal~{goalName}~{goalDescrip}~{goalPointVal}~{completionBool}";

        //Add new entry containing info above to userGoalsList.
        userGoalList.Add(SimpleParseableString);

    }

    //virtual method is default for SimpleGoal class.
    public virtual void RecordEvent()
    {
        Console.WriteLine("Please confirm that you would like to record this goal (confirm the number by typing it again): ");
        string goalsListingSelection = Console.ReadLine();

        List<string> separatedEntryList = userGoalList[int.Parse(goalsListingSelection) - 1].Split('~').ToList();

        separatedEntryList[4] = "true";

        // Updating the list with the changed string!
        userGoalList[int.Parse(goalsListingSelection) - 1] = string.Join("~", separatedEntryList);

        string points = separatedEntryList[3];
        Console.WriteLine($"Congratulations! You have earned {points} points! ");
        _pointsTotal += int.Parse(points);
    }
    
    public void ListGoals()
    {
        //Logic for ListGoals() is short enough that instead of a virtual method, I placed all the code here.
        //This method does a great job at parsing the raw strings that are stored on the txt file.
        int count = 1;
        foreach (string entry in userGoalList)
        {
            List<string> separatedEntryList = entry.Split('~').ToList();

            //this is used to save a value to be passed to the program class when deciding which
            //RecordEvent() child class to use!
            _displayedGoalTypeList.Add(separatedEntryList[0]);

            if (separatedEntryList[0] == "SimpleGoal")
            {
                string goalName = separatedEntryList[1];
                string goalDescrip = separatedEntryList[2];
                bool completionBool = bool.Parse(separatedEntryList[4]);

                if (completionBool == false)
                {
                    Console.WriteLine($"{count}. [ ] {goalName} ({goalDescrip})");   
                }
                else if (completionBool == true)
                {
                    Console.WriteLine($"{count}. [X] {goalName} ({goalDescrip})");
                }
                count += 1;
            }
            else if (separatedEntryList[0] == "EternalGoal")
            {
                string goalName = separatedEntryList[1];
                string goalDescrip = separatedEntryList[2];

                Console.WriteLine($"{count}. [ ] {goalName} ({goalDescrip})");   
                count += 1;
            }
            else if (separatedEntryList[0] == "ChecklistGoal")
            {
                string goalName = separatedEntryList[1];
                string goalDescrip = separatedEntryList[2];
                int reqCompletions = int.Parse(separatedEntryList[5]);
                int actualCompletions = int.Parse(separatedEntryList[6]);

                if (actualCompletions >= reqCompletions)
                {
                    Console.WriteLine($"{count}. [X] {goalName} ({goalDescrip}) {actualCompletions}/{reqCompletions}");   
                }
                else
                {
                    Console.WriteLine($"{count}. [ ] {goalName} ({goalDescrip}) {actualCompletions}/{reqCompletions}");
                }
                count += 1;
            }   
        }
    }
    
    public List<string> PassUserGoalsList()
    {
        return userGoalList;
    }

    public List<string> PassDisplayedGoalTypeList()
    {
        return _displayedGoalTypeList;
    }
}