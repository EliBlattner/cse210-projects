using System;
using System.Formats.Asn1;
using System.IO;

//The SaveAndLoad class was originally part of the Write class. I decided to move it to its own dedicated class for readability
public class SaveAndLoad
{
    public void SaveEntriesToCSV(List <string> _entriesList, string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath, false);
        {
            foreach (string entry in _entriesList)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadEntriesFromCSV(List <string> _entriesList, string filePath) //This bit required me to use some code from OpenAI, specifically for the try/catch error handling parts
    {
        try
        {
            _entriesList.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _entriesList.Add(line);
                }
            }
            Console.WriteLine($"Entries have been loaded to {filePath} successfully.");
        }
        catch
        {
            Console.WriteLine($"Error loading entries from {filePath}");
        }
    }
}