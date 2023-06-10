using System;
using System.Diagnostics;
using System.Threading;


class WaitingDisplay
{
    int spinnerCounter = 0;

    public List<string> GetMultipleLinesWithTimer(int numSecondsToRun)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        List<string> list = new List<string>();
        while (stopWatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            Console.Write(">");
            string line = Console.ReadLine();
            list.Add(line);
        }
        Console.Write("");
        Console.WriteLine("");
        return list;
    }

    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        while (stopWatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }


        Console.Write("");
        Console.WriteLine("");
    }

    public void displaySpinnerWithText(List<string> list, int numSecondsToRun)
    {
        foreach (string item in list)
        {
            Console.Write($"{item}");
            displaySpinner(numSecondsToRun);
        }

    }

    public void displayCountDown(int numSecondsToRun, int totalActivity, List<string> list = default(List<string>), string text = "")
    {
        if (list?.Any() == true)
        {
            while (totalActivity > numSecondsToRun)
            {
                foreach (string item in list)
                {
                    for (int i = numSecondsToRun; i >= 1; i--)
                    {
                        Console.Write($"{item}...{i}");
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Thread.Sleep(1000);
                    }

                    Console.Write("");
                    Console.WriteLine("");
                    totalActivity = totalActivity - numSecondsToRun;
                }
            }

            Thread.Sleep(200);
        }
        else
        {
            for (int i = numSecondsToRun; i >= 1; i--)
            {
                Console.Write($"{text} {i}");
                Console.SetCursorPosition(0, Console.CursorTop);
                Thread.Sleep(1000);
            }
            
            Console.Write("");
            Console.WriteLine("");
            Thread.Sleep(200);
        }
    }
}