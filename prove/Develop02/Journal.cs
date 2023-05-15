using System;
using System.IO;
using System.Collections.Generic;

class Journal
{

    public string _fileName = string.Empty;


    public Journal()
    {

    }

    public void CreateFile()
    {
        using (FileStream fs = File.Create(_fileName)) { }
    }

    public void WriteFile(string _line)
    {
        using (StreamWriter outputFile = File.AppendText(_fileName))
        {
            outputFile.WriteLine(_line);
        }
    }
    public void DisplayContentFile()
    {
        using (StreamReader _sr = File.OpenText(_fileName))
        {
            string _s = "";
            while ((_s = _sr.ReadLine()) != null)
            {
                Console.WriteLine(_s);
            }
        }
    }

}