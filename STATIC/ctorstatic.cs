using System;

class Logger
{
    public static string logPath;

    // Static Constructor
    static Logger()
    {
        logPath = "C:\\Logs\\logfile.txt";
        Console.WriteLine("Static Constructor Called: Log Path Initialized");
    }

    public static void ShowLogPath()
    {
        Console.WriteLine($"Log Path: {logPath}");
    }
}

class Program
{
    //static void Main()
    //{
    //    Logger.ShowLogPath(); // Static Constructor यहाँ execute होगा
    //    Logger.ShowLogPath(); // अब दुबारा execute नहीं होगा
    //}
}
