using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static string _activityType;

    static void Main(string[] args)
    {
        //Following section takes care of the menu interface and activity type
        //assignment based on user input. Instantiates classes and executes methods and constructors.
        string _userMenuChoice = "99";

        Console.WriteLine("\nWelcome to the Wellness Program!");
        Thread.Sleep(2000);

        while (_userMenuChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("\nEnter Menu Choice: \n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit\n");
            _userMenuChoice = Console.ReadLine();
            Activity activity1 = new Activity();

            if (_userMenuChoice == "1")
            {
                _activityType = "Breathing";
                activity1.StartupMessage(_activityType);
                int countdown = activity1.PassCountdown();
                BreathingActivity breathingActivity1 = new BreathingActivity();
                breathingActivity1.BreathingExcercise(countdown);

                activity1.EndMessage(_activityType);
            }
            else if (_userMenuChoice == "2")
            {
                _activityType = "Reflecting";
                activity1.StartupMessage(_activityType);
                int countdown = activity1.PassCountdown();
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                reflectingActivity1.ReflectingExcercise(countdown);

                activity1.EndMessage(_activityType);
            }
            else if (_userMenuChoice == "3")
            {
                _activityType = "Listing";
                activity1.StartupMessage(_activityType);                
                int countdown = activity1.PassCountdown();
                ListingActivity listingActivity1 = new ListingActivity();
                listingActivity1.ListingExcercise(countdown);

                activity1.EndMessage(_activityType);
            }            
        }
        Console.WriteLine("\n\nClosing program...\n");
    }
    //static string PassActivtyType()
    //    {
    //        return _activityType;
    //    }

}