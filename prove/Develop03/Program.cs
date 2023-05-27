using System;

class Program
{
    static void Main(string[] args)
    {
        Loadscript newScripture = new Loadscript();
        newScripture.LoadToFile();
        string type = "";
        Scripture scripture = newScripture.getScripture();
        Reference reference = scripture.getReference();

        while (type != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{reference.getReference()} {scripture.getRenderedText()}\n");
            Console.WriteLine("\nOptions: \n-------------------------- \n> Press Enter To Continue \n> Type 'quit' To Finish.\n--------------------------");
            type = Console.ReadLine();
            Console.Clear();
            scripture.hideWords();

            if(scripture.isCompletelyHidden())
            {
                type = "quit";
            }
        }
    }
}