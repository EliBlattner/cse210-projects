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

    









    public void CreateBoolList(bool _multiVersesExist, List<string>_verseWordsList1, List<string>_verseWordsList2)
    {
        //produces a list the same size as _verseWordsList that holds boolean values at each corresponding
        //index, to be used when deciding which words to hide.
        if (_multiVersesExist == true)
        {
            foreach (var word in _verseWordsList1)
            {
                _boolIndexList1.Add(true);
            }
        }
        else
        {
            foreach (var word in _verseWordsList2)
            {
                _boolIndexList2.Add(true);
            }
        }
    }

    public void AssignHiddenWords(bool _multiVersesExist, List<string> _verseWordsList1, List<string>_verseWordsList2)
    {
        //gets random number and replaces the index in the boolIndexList with false. (false = hide)
        var random = new Random();
        if (_multiVersesExist)
        {
            int randomNumber1 = random.Next(1, _verseWordsList1.Count);
            _boolIndexList1[randomNumber1] = false;

            int randomNumber2 = random.Next(1, _verseWordsList1.Count);
            _boolIndexList1[randomNumber2] = false;

            int randomNumber3 = random.Next(1, _verseWordsList1.Count);
            _boolIndexList1[randomNumber3] = false;
        }
        else
        {
            int randomNumber1 = random.Next(1, _verseWordsList2.Count);
            _boolIndexList2[randomNumber1] = false;
        }
    }

    public void GetRenderedText(bool _multiVersesExist, List<string>_verseWordsList1, List<string>_verseWordsList2)
    {
        //Formats each word in the verse(s). Iterates through each word in the WordsLists. If its 
        //corresponding positional value in the _boolIndexList is true, it assigns "_ _ _" to the
        //string. Otherwise, the normal word is passed through.

        if (_multiVersesExist == true)
        {
            int icount = 0;
            foreach (var word in _verseWordsList1)
            {
                //hide word if boolIndex is false
                if (_boolIndexList1[icount] == false)
                {
                    int underscoreCount = word.Length;
                    _hiddenScriptureList1.Add(new string('_', underscoreCount));
                }
                else
                {
                    _hiddenScriptureList1.Add(word);
                }

                icount += 1;
            }

            icount = 0;
            foreach (var word in _verseWordsList2)
            {
                //hide word if boolIndex is false
                if (_boolIndexList2[icount] == false)
                {
                    int underscoreCount = word.Length;
                    _hiddenScriptureList1.Add(new string('_', underscoreCount));
                }
                else
                {
                    _hiddenScriptureList2.Add(word);
                }

                icount += 1;
            }
        }
        else
        {
            int icount = 0;
            foreach (var word in _verseWordsList1)
            {
                //hide word if boolIndex is false
                if (_boolIndexList1[icount] == false)
                {
                    int underscoreCount = word.Length;
                    _hiddenScriptureList2.Add(new string('_', underscoreCount));
                }
                else
                {
                    _hiddenScriptureList2.Add(word);
                }

                icount += 1;
            }
        }
        
        //Text is then appended into a single string.
        _finalScripture1 = string.Join(" ", _hiddenScriptureList1);
        //Text is then wrapped (not my code).
        WrapText(_finalScripture1);
        
    }

    //I spent AGES trying to get a text wrapping feature set, but it was just too
    //advanced for my level. OpenAI is responsible for most of this function.
    private void WrapText(string text)
    {
        int maxLineLength = 80; // Adjust the line length as needed
        int currentPosition = 0;
        List<string> lines = new List<string>();
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            if (currentPosition + word.Length + 1 <= maxLineLength)
            {
                if (!string.IsNullOrEmpty(lines.LastOrDefault()))
                {
                    lines[lines.Count - 1] += " ";
                    currentPosition++;
                }
                lines.Add(word);
                currentPosition += word.Length;
            }
            else
            {
                lines.Add(word);
                currentPosition = word.Length;
            }
        }

        _finalScripture1 = string.Join("\n", lines);
    }

    public void ShowFinalText(bool _multiVersesExist,string _bookName,string _chapterNumber,string _verseNumber1,string _verseNumber2)
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