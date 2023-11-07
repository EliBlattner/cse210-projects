using System;
using Microsoft.VisualBasic;

class Program
{

    private string _userInput = "null";
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










    }
}