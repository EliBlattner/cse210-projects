using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Word
{
    private List<bool> _boolIndexList1;
    private List<bool> _boolIndexList2;

    private List<string> _hiddenScriptureList1;
    private List<string> _hiddenScriptureList2;

    private string _finalScripture1;
    private string _finalScripture2;



    public Word()
    {
        //Creates empty lists for the methods used in the function.
        _boolIndexList1 = new List<bool>();
        _boolIndexList2 = new List<bool>();

        _hiddenScriptureList1 = new List<string>();
        _hiddenScriptureList2 = new List<string>();
    
    }









    public void CreateBoolList(_multiVersesExist, _verseWordsList1, _verseWordsList2)
    {
        //produces a list the same size as _verseWordsList that holds boolean values at each corresponding
        //index, to be used when deciding which words to hide.
        if (_multiVersesExist == true)
        {
            for index in _verseWordsList1
            {
                _boolIndexList1.Add(true);
            }
        }
        else
        {
            for index in _verseWordsList2
            {
                _boolIndexList2.Add(true);
            }
        }
    }

    public void AssignHiddenWords(_multiVersesExist, _verseWordsList1, _verseWordsList2)
    {
        //gets random number and replaces the index in the boolIndexList with false. (false = hide)
        randomNumber1 = getrandomnumber(1,len(wordverselist))
        _boolIndexList1.replace(_boolIndexList1[randomNumber1], with false);
        randomNumber2 = getrandonnumber(1,len(wordverselist))
        _boolIndexList1.replace(_boolIndexList1[randomNumber2], with false);
        randomNumber3 = getrandonnumber(1,len(wordverselist))
        _boolIndexList1.replace(_boolIndexList1[randomNumber1], with false);
    }

    public void GetRenderedText(_multiVersesExist, _verseWordsList1, _verseWordsList2)
    {
        //Formats each word in the verse(s). Iterates through each word in the WordsLists. If its 
        //corresponding positional value in the _boolIndexList is true, it assigns "_ _ _" to the
        //string. Otherwise, the normal word is passed through.

        if (_multiVersesExist == true)
        {
            int icount = 0;
            for word in _verseWordsList1
            {
                //hide word if boolIndex is false
                if (_boolIndexList1[icount] == false)
                {
                    int underscoreCount = len(word)
                    _hiddenScriptureList1[icount] = ("_" * underscoreCount);
                }
                else
                {
                    _hiddenScriptureList1[icount] = _verseWordsList1[icount];
                }

                icount += 1;
            }

            icount = 0;
            for word in _verseWordsList2
            {
                //hide word if boolIndex is false
                if (_boolIndexList2[icount] == false)
                {
                    int underscoreCount = len(word)
                    _hiddenScriptureList2[icount] = ("_" * underscoreCount);
                }
                else
                {
                    _hiddenScriptureList2[icount] = _verseWordsList2[icount];
                }

                icount += 1;
            }
        }
        else
        {
            int icount = 0:
            for word in _verseWordsList1
            {
                //hide word if boolIndex is false
                if (_boolIndexList1[icount] == false)
                {
                    int underscoreCount = len(word)
                    _hiddenScriptureList1[icount] = ("_" * underscoreCount);
                }
                else
                {
                    _hiddenScriptureList1[icount] = _verseWordsList1[icount];
                }

                icount += 1;
            }
        }
        
        
        
        
        //Text is then appended into a single string.
        _finalScripture1 = combinestring(_hiddenScriptureList1);


        //Wraps text so it can be displayed in a neater format (readability).
        wraptext(_finalScripture1)
        
    }

    public void ShowFinalText(_multiVersesExist, _bookName, _chapterNumber, _verseNumber1, _verseNumber2)
    {
            //clear screen;

            //display the modified and scripture's formatted text all together.

            if (_multiVersesExist == true)
            {
                Console.WriteLine($"{_bookName} {_chapterNumber}: {_verseNumber1}-{_verseNumber2}\n\n{_verseNumber1} {_finalScripture1}\n\n{_verseNumber2} {_finalScripture2}");
            }
            else
            {
                Console.WriteLine($"{_bookName} {_chapterNumber}: {_verseNumber1}\n\n{_verseNumber1} {_finalScripture1})");
            }
}