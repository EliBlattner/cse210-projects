using System;
using System.Security.Cryptography.X509Certificates;

public class Write
{

    public string _userEntry;
    public DateTime _currentDateTime;

    List<string> _promptBankList = new List<string>{"What is something that went well today?", "What was the hardest thing you accomplished today?", "Write about a funny thing that happened today", "What is something you noticed today, that you need to work on tomorrow?"};
    
    static Random random = new Random();

    int randomIndex = random.Next(0,3);
    
    public List<string> _entriesList = new List<string>();


    public string Display()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"{_currentDateTimeStr} , {_promptBankList[randomIndex]} , {_userEntry}");
        return $"{_currentDateTimeStr} , {_promptBankList[randomIndex]} , {_userEntry}";
    } 
   public string Display2()
   {
        Console.WriteLine(_promptBankList[randomIndex]);
        return _promptBankList[randomIndex];

   }

   public string Display3()
   {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        string result = $"{_currentDateTimeStr} , {_promptBankList[randomIndex]} , {_userEntry}"; // Call the Display method and capture its result
        _entriesList.Add(result); // Add the result to the _entriesList
        return result;
        
   }
}