using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Write
{
    public string _userEntry;
    public DateTime _currentDateTime;

    List<string> _promptBankList = new List<string>
    {
        "What is something that went well today?",
        "What was the hardest thing you accomplished today?",
        "Write about a funny thing that happened today.",
        "What is something you noticed today, that you need to work on tomorrow?",
        "What was the most memorable interaction you had with someone?"
    };

    static Random random = new Random();
    int randomIndex;
    public List<string> _entriesList = new List<string>();

    public string Display()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = _promptBankList[randomIndex];
        Console.WriteLine($"{_currentDateTimeStr} | {prompt} | {_userEntry}");
        return $"{_currentDateTimeStr} | {prompt} | {_userEntry}";
    }

    public string Display2()
    {
        randomIndex = random.Next(0, _promptBankList.Count);
        string prompt = _promptBankList[randomIndex];
        Console.WriteLine(prompt);
        return prompt;
    }

    public string Display3()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = _promptBankList[randomIndex];
        string result = $"{_currentDateTimeStr} | {prompt} | {_userEntry}";
        _entriesList.Add(result);
        return result;
    }
}