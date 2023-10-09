using System;
using System.Collections.Generic;

public class Write
{
    public string _userEntry;
    public DateTime _currentDateTime;

    List<string> _promptBankList = new List<string>
    {
        "What is something that went well today?",
        "What was the hardest thing you accomplished today?",
        "Write about a funny thing that happened today.",
        "What is something you noticed today, that you need to work on tomorrow?"
    };

    static Random random = new Random();
    int randomIndex; // Store the random index for the session

    public List<string> _entriesList = new List<string>();

    public string Display()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = _promptBankList[randomIndex];
        Console.WriteLine($"{_currentDateTimeStr} | {prompt}\n{_userEntry}");
        return $"{_currentDateTimeStr} | {prompt}\n{_userEntry}";
    }

    public string Display2()
    {
        randomIndex = random.Next(0, _promptBankList.Count); // Generate a new random index
        string prompt = _promptBankList[randomIndex];
        Console.WriteLine(prompt);
        return prompt;
    }

    public string Display3()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = _promptBankList[randomIndex];
        string result = $"{_currentDateTimeStr} | {prompt}\n{_userEntry}";
        _entriesList.Add(result);
        return result;
    }
}