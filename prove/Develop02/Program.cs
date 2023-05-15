using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int _choice = 0;
        string _PromptText = string.Empty;
        string _FileName = String.Empty;
        Journal _journal = new Journal();
        Entry _entry = new Entry();
        _entry.LoadMenu();

        while (_choice != 5)
        
        {
            _entry.menu();
            _choice = int.Parse(Console.ReadLine());
            if (_choice == 1)
            {
                Prompt _prompt = new Prompt();
                _PromptText = _prompt.DisplayRndPrompt();
                Console.WriteLine(_PromptText);
                string _choiceEntry = Console.ReadLine();
                string _dateText = _entry.DateToString();
                _entry._entries.Add($"Date: {_dateText} - Prompt: {_PromptText} \n {_choiceEntry}");
            }

            else if (_choice == 2)
            {
                if (File.Exists(_journal._fileName))
                {
                    _journal.DisplayContentFile();
                }
                else
                {
                    foreach (string prompt in _entry._entries)
                    {
                        Console.WriteLine($"{prompt}");
                    }
                }
            }

            else if (_choice == 3)
            {
                Console.WriteLine("What is the file name? ");
                _FileName = Console.ReadLine();
                _journal._fileName = _FileName;

            }

            else if (_choice == 4)
            {
                if (File.Exists(_journal._fileName))
                {
                    foreach (string p in _entry._entries)
                    {
                        _journal.WriteFile(p);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter your filename as a .txt");
                    _FileName = Console.ReadLine();
                    _journal._fileName = _FileName;
                    _journal.CreateFile();
                    foreach (string p in _entry._entries)
                    {
                        _journal.WriteFile(p);
                    }
                }
            }
        }
    }
}