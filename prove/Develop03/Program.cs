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

        wordINST.AssignHiddenWords(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
        wordINST.GetRenderedText(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
        wordINST.AllHiddenCheck2(referenceINST.PassMultiverseBool());
        wordINST.PassAllHiddenValue();
        string _userLoopInput = "none";

        while (_userLoopInput != "quit")
        {
            if (wordINST.PassAllHiddenValue() != true)
            {
                wordINST.ShowFinalText(referenceINST.PassMultiverseBool(), referenceINST.PassBookName(), referenceINST.PassChapterNumber(), referenceINST.PassVerseNumber1(), referenceINST.PassVerseNumber2());

                Console.WriteLine("\nPress enter to hide words or type 'quit' to exit: \n");
                _userLoopInput = Console.ReadLine();

                wordINST.AssignHiddenWords(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
                wordINST.GetRenderedText(referenceINST.PassMultiverseBool(),scriptureINST.GetVerseWordsList1(),scriptureINST.GetVerseWordsList2());
                wordINST.AllHiddenCheck2(referenceINST.PassMultiverseBool());

            }
            else
            {
                Console.WriteLine("\n\n\nCongratulations! You memorized the Scripture!");
                break;
            }
        }

        Console.WriteLine("Exiting the program...");
    }
}