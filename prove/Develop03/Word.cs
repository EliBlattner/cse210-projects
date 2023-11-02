using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Word
{

private List<bool> _verseListHiddenBool1;
private List<bool> _verseListHiddenBool2;















    public void IsHidden(_multiVersesExist, _verseWordsList1, _verseWordsList2)
    {
        //Assigns true or false to each word in the list of words in 1 or 2 verses.
    }

    public void GetRenderedText(_multiVersesExist, )
    {
        //Formats each word in the verse(s). Iterates through each word in the WordsLists

        
    }

    public void Show(_multiVersesExist, _verseWordsList1, _verseWordsList2, _bookName, _chapterNumber)
    {
        //Clears the screen and displays the information from getrenderedtext method
        //Clear Screen

            clear screen;

            Console.WriteLine($"{Book} {Chapter} {Verse1}-{Verse2}: ");
            Console.WriteLine($"{Verse1} {VerseWordList1}");
            Console.WriteLine($"{Verse1} {Verse2} ");

    }
}