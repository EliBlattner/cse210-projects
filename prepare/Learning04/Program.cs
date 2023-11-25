using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment();
        mathAssignment1.ShowMathAssignment();

        WritingAssignment writingAssignment1 = new WritingAssignment();
        writingAssignment1.ShowWritingAssignment();

    }
}