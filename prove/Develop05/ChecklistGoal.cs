public class ChecklistGoal : Goal
{
    public override void CreateNewGoal()
    {
        Console.WriteLine("What is the name of the goal?: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?: ");
        string goalDescrip = Console.ReadLine();
        Console.WriteLine("What is the point value of the goal?: ");
        int goalPointVal = int.Parse(Console.ReadLine());
        Console.WriteLine("How many completions of this goal will occur before a bonus is given?: ");
        int goalBonusThresh = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the amount of points earned from this bonus?: ");
        int pointsFromBonus = int.Parse(Console.ReadLine());
        int completedTimes = 0;

        string SimpleParseableString = $"ChecklistGoal~{goalName}~{goalDescrip}~{goalPointVal}~{pointsFromBonus}~{goalBonusThresh}~{completedTimes}";

        userGoalList.Add(SimpleParseableString);
    }
        //Add new entry containing info above to userGoalsList.

    public override void RecordEvent()
    {
        Console.WriteLine("Please confirm that you would like to record this goal (confirm the number by typing it again): ");
        string goalsListingSelection = Console.ReadLine();
        List<string> separatedEntryList = userGoalList[int.Parse(goalsListingSelection) - 1].Split('~').ToList();
        // Updating the list with the changed string!
        int goalPointVal = int.Parse(separatedEntryList[3]);
        int pointsFromBonus = int.Parse(separatedEntryList[4]);
        //Logic for calculating the completion of a checklist goal.
        int checklistCount = int.Parse(separatedEntryList[6]);
        checklistCount += 1;
        separatedEntryList[6] = checklistCount.ToString();
        userGoalList[int.Parse(goalsListingSelection) - 1] = string.Join("~", separatedEntryList);

        if (separatedEntryList[6] == separatedEntryList[5])
        {
            _pointsTotal += goalPointVal + pointsFromBonus;
        }
        else
        {
            pointsFromBonus = 0;
            _pointsTotal += goalPointVal;
        }
        Console.WriteLine($"Congratulations! You have earned {goalPointVal + pointsFromBonus} points! ");
    }
}