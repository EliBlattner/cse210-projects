public class EternalGoal : Goal
{        
    public override void CreateNewGoal()
    {
        Console.WriteLine("What is the name of the goal?: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?: ");
        string goalDescrip = Console.ReadLine();
        Console.WriteLine("What is the point value of the goal?: ");
        int goalPointVal = int.Parse(Console.ReadLine());

        string SimpleParseableString = $"EternalGoal~{goalName}~{goalDescrip}~{goalPointVal}";

        //Add new entry containing info above to userGoalsList.
        userGoalList.Add(SimpleParseableString);
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Please confirm that you would like to record this goal (confirm the number by typing it again): ");
        string goalsListingSelection = Console.ReadLine();

        List<string> separatedEntryList = userGoalList[int.Parse(goalsListingSelection) - 1].Split('~').ToList();

        int goalPointVal = int.Parse(separatedEntryList[3]);

        // Updating the list with the changed string!
        userGoalList[int.Parse(goalsListingSelection) - 1] = string.Join("~", separatedEntryList);

        Console.WriteLine($"Congratulations! You have earned {goalPointVal} points! ");
        _pointsTotal += goalPointVal;
    }

    public int PassEternalPoints()
    {
        return _pointsTotal; 
    }
}