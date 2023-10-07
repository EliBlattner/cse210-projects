using System;

class Program
{
    static void Main(string[] args)
    {
        //Write class operations below
        Write write1 = new Write();
        write1._userEntry = "this is my first entry";
        write1._currentDateTime = DateTime.Now;
        write1._promptSelection = "Insert current prompt list iteration";

        Show show1 = new Show();
        show1._entriesList.Add(write1.Display());

        write1.Display();
    }
}