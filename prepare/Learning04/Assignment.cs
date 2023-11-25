
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        Console.WriteLine("Please enter the student's name: ");
        _studentName = Console.ReadLine();
        Console.WriteLine("\nPlease enter the topic: ");
        _topic = Console.ReadLine();
    }
    public string ShowNameTopic()
    {
        return $"{_studentName}\n{_topic}";
    } 
}