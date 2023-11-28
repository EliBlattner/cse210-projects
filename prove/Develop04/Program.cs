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

        Console.WriteLine("Welcome to the Wellness Program!\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit");

        while (_userMenuChoice != "4")
        {
            Console.WriteLine("Enter Menu Choice. Type '4' to exit the program: ");
            _userMenuChoice = Console.ReadLine();

            Activity activity1 = new Activity();

            if (_userMenuChoice == "1")
            {
                _activityType = "Breathing";
                activity1.StartupMessage(_activityType);
                BreathingActivity breathingActivity1 = new BreathingActivity();



                activity1.EndMessage(_activityType);
            }
            else if (_userMenuChoice == "2")
            {
                _activityType = "Reflecting";
                activity1.StartupMessage(_activityType);
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();



                activity1.EndMessage(_activityType);
            }
            else if (_userMenuChoice == "3")
            {
                _activityType = "Listing";
                activity1.StartupMessage(_activityType);
                ListingActivity listingActivity1 = new ListingActivity();



                activity1.EndMessage(_activityType);
            }            
        }
    }
    //static string PassActivtyType()
    //    {
    //        return _activityType;
    //    }

}