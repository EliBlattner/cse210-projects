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

        write1.Display();
    }
}