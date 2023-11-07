using System;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference referenceINST = new Reference();
        Scripture scriptureINST = new Scripture();
        referenceINST.PassReferenceValues();
        referenceINST.ProcessReferenceValuesInScripture(scriptureINST);

        Word wordINST = new Word();
        wordINST.CreateBoolList(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());

        wordINST.AllHiddenCheck2(referenceINST.PassMultiverseBool());
        string _userLoopInput = "none";

        while (_userLoopInput != "quit")
        {
            if (wordINST.PassAllHiddenValue() != true)
            {
                Console.WriteLine("\n\n\nPress enter to hide words or type 'quit' to exit: \n");
                _userLoopInput = Console.ReadLine();

                wordINST.AssignHiddenWords(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
                wordINST.GetRenderedText(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
            }
            else
            {
                break;
            }
        }
    }
}