using System.Runtime.CompilerServices;

public class Reference
{

    private bool _multiVersesExist;

    private string _bookName;

    private string _verseNumber1;

    private string _verseNumber2;

    private string _verseText1;

    private string _verseText2;

    private string _chapterNumber;


    //Uses logic to assign _multiVerseExists member variable true or false if reference contains either 1 or 2 verses.
    //This will be used to tell the constructors in the Scripture class how to behave. 
    public Reference()
    {
        Console.WriteLine("Hello! Does your scripture reference contain more than one verse? (yes/no): ");
        string multipleVersesInput = Console.ReadLine();
        Console.WriteLine("What is the name of the book the scripture comes from?: ");
        _bookName = Console.ReadLine();
        Console.WriteLine("What is the chapter number the verse is found in?: ");
        _chapterNumber = Console.ReadLine();


        if (multipleVersesInput == "yes")
        {
            _multiVersesExist = true;
            
            Console.WriteLine("Which number verse is the first verse?: ");
            _verseNumber1 = Console.ReadLine();
            Console.WriteLine("Which number verse is the second verse?: ");
            _verseNumber2 = Console.ReadLine();
            Console.WriteLine("What is the content of the first verse? (copy and paste the text): ");
            _verseText1 = Console.ReadLine();
            Console.WriteLine("What is the content of the second verse? (copy and past the text): ");
            _verseText2 = Console.ReadLine();


        }
        else
        {
            _multiVersesExist = false;

            Console.WriteLine("Which number is the verse?: ");
            _verseNumber1 = Console.ReadLine();
            Console.WriteLine("What is the content of the verse? (copy and past the text): ");
            _verseText1 = Console.ReadLine();

        }
    }

    //This method takes all the attributes and passes them in an encapsulated form as a collection of return values.
    public (bool, string, string, string, string, string, string) PassReferenceValues()
    {
        return (_multiVersesExist,_verseNumber1,_verseNumber2,_verseText1,_verseText2,_bookName,_chapterNumber);
    }

    //This method's sole purpose is to enable the member variables defined in this constructor to be passed over to
    //the ParseScripCreateList method within the Scripture class.
    public void ProcessReferenceValuesInScripture(Scripture scripture)
    {
        var values = PassReferenceValues();
        scripture.ParseScripCreateList(values.Item1, values.Item4, values.Item5);
    }

    //This does the same thing but for the methods in the Word class.
    
    //public void WordClassMethodNULL(Word word)
    //{
    //    var values = PassReferenceValues(values.Item1, values.Item6, values.Item7);
    //}
}   