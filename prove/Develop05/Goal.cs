public class Goal
{
    List<string> goalStringList = new List<string>();

    

    public virtual string CreateNewGoal()
    {
        Console.WriteLine("What is the name of the goal?: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?: ");
        string goalDescrip = Console.ReadLine();
        Console.WriteLine("What is the point value of the goal?: ");
        int goalPointVal = int.Parse(Console.ReadLine());


    }

    public virtual string RecordEvent()
    {
        //LIST Goals
        //Let user pick goal from current list
    }
}