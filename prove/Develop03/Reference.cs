using System.Runtime.CompilerServices;

public class Reference
{

    private bool _multiVersesExist;


    //Uses logic to assign _multiVerseExists member variable true or false if reference contains either 1 or 2 verses.
    //This will be used to tell the constructors in the Scripture class how to behave. 
    private Reference()
    {
        Console.WriteLine("Hello! Does your scripture reference contain more than one verse? (yes/no): ");
        string multipleVerses = Console.ReadLine();
        if (multipleVerses == "yes")
        {
            _multiVersesExist = true;
        }
        else
        {
            _multiVersesExist = false;
        }
    }
}