using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment();
        WritingAssignment writingAssignment1 = new WritingAssignment();

        mathAssignment1.ShowMathAssignment();
        Console.WriteLine("");
        writingAssignment1.ShowWritingAssignment();

    }
}