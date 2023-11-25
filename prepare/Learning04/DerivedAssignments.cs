
using System.Diagnostics.Contracts;
using System.Dynamic;

//MATH ASSIGNMENT SUBCLASS
public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _mathProblems;

    //CONSTRUCTOR
    public MathAssignment()
    {
        Console.WriteLine("Please enter the textbook section: ");
        _textBookSection = Console.ReadLine();
        Console.WriteLine("\nPlease enter the math problems: ");
        _mathProblems = Console.ReadLine();
    }

    //METHOD
    public void ShowMathAssignment()
    {
        Console.WriteLine($"{ShowNameTopic()} \n{_textBookSection} \n{_mathProblems}");
    }
}


//WRITING ASSIGNMENT SUBCLASS
public class WritingAssignment : Assignment
{
    private string _assignmentTitle;

    //CONSTRUCTOR
    public WritingAssignment()
    {
        Console.WriteLine("Please enter the assignment title: ");
        _assignmentTitle = Console.ReadLine();
    }

    //METHOD
    public void ShowWritingAssignment()
    {
        Console.WriteLine($"{ShowNameTopic()} \n{_assignmentTitle}");
    }
}