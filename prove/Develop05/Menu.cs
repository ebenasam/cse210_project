public abstract class Menu
{
    private List<string> _menuList = new List<string>();
    private int _userEntry = 0;

    public Menu()
    {

    }

    public int DisplayMenu()
    {
        WriteMenuItems();
        bool isValidInput = CheckIfValid();

        while (!isValidInput || _userEntry > _menuList.Count -2 || _userEntry < 1)
        {
            Console.Clear();
            Console.WriteLine("Invalid Entry.  Please choose a valid Menu Item.");
            WriteMenuItems();
            isValidInput = CheckIfValid();
        }
        return _userEntry;
    }
    private void WriteMenuItems()
    {
        foreach (string i in _menuList)
        {
            Console.Write(i);
        }
    }

    private bool CheckIfValid()
    {
        return int.TryParse(Console.ReadLine(),out _userEntry);
    }

    public void AddMenuItem(string menuItem)
    {
        _menuList.Add(menuItem);
    }

    public abstract void BuildMenu();
}