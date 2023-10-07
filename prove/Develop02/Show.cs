using System;

public class Show
{
    public string _combinedEntryIndiv;

    public List<string> _entriesList = new List<string>();

    public void Display()
    {
        foreach (string entry in _entriesList)
        {
            int _entryNumber = 1;
            string _entryNumberString = _entryNumber.ToString();
            Console.WriteLine($"Journal Entry #{_entryNumberString}");
            Console.WriteLine($"{entry}\n-----------------");
            _entryNumber += 1;
        }
    }

}