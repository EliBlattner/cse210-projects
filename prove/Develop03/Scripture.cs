using System.ComponentModel;
using System.Runtime.InteropServices;

public class Scripture
{
    //declares member variables to store segmented scripture into a list for 1 verse, or 2 verses
    private List<string> _verseWordsList1;
    private List<string> _verseWordsList2;
    
        public Scripture()
    {
        _verseWordsList1 = new List<string>();
        _verseWordsList2 = new List<string>();
    }

    //passes a parameter to scripture constructor to perform dependent action. Just 1 verse will
    //create a single list, while 2 verses will create 2 lists.
    public void ParseScripCreateList(bool _multiVersesExist, string _verseText1, string _verseText2)
    {
        if (_multiVersesExist)
        {
            //parses _verseText1 and _verseText2, and assigns them to respective lists.

            string[] words1 = _verseText1.Split(' ');
            _verseWordsList1.AddRange(words1);

            string[] words2 = _verseText2.Split(' ');
            _verseWordsList2.AddRange(words2);

        }
        else
        {
            //parses _verseText1 and assigns it to a list.

            string[] words1 = _verseText1.Split(' ');
            _verseWordsList1.AddRange(words1);
        }

    }

    public List<string> GetVerseWordsList1()
    {
        return _verseWordsList1;
    }

    public List<string> GetVerseWordsList2()
    {
        return _verseWordsList2;
    }

}