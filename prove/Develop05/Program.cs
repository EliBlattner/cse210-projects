using System;

class Program
{
    static void Main(string[] args)
    {
        string _userMenuChoice = "99";
        Goal goal1 = new Goal();

        while (_userMenuChoice != "6")
        {
            Console.WriteLine($"You have __ points.\n");
            Thread.Sleep(1000);

            Console.WriteLine("\nMenu Options: \n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\n");

            _userMenuChoice = Console.ReadLine();

            if (_userMenuChoice == "1")
            {
                Console.WriteLine("Which type of goal would you like to create?:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n");
                string _userGoalTypePick = Console.ReadLine();

                if (_userGoalTypePick == "1")
                {
                    //Do SimpleGoal method action.
                    goal1.CreateNewGoal();
                    goal1.ListGoals();
                    goal1.RecordEvent();
                    goal1.ListGoals();

                }
                else if (_userGoalTypePick == "2")
                {
                    //Do EternalGoal method action.
                }
                else if (_userGoalTypePick == "3")
                {
                    //Do ChecklistGoal method action.
                }
            }
            else if (_userMenuChoice == "2")
            {
                //List the string form goals from the complete goals list.
            }
            else if (_userMenuChoice == "3")
            {
                //Save current goals list to a txt file.
            }
            else if (_userMenuChoice == "4")
            {
                //Read a txt file containing goals. Overwrite the goals list with entries found in the txt file.
            }
            else if (_userMenuChoice == "5")
            {
                //Record a goal event. Read a txt file containing goals. Update Goals string list to make changes. Re-display txt file.
            }       
        }


    }
}