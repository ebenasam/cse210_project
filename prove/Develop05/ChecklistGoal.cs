public class ChecklistGoal: Goal
{
    
    public ChecklistGoal(bool isNew):base(isNew)
    {
        if (isNew){
            Console.WriteLine ("How many times does this goal need to be accomplished for a bonus?  ");
            int userInput =-1;

            while (!int.TryParse(Console.ReadLine(),out userInput))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.\nHow many times does this goal need to be accomplished for a bonus?  ");
            }
                base.SetNumMax(userInput);
                userInput = -1; 

            Console.WriteLine("What is the bonus for accomplishing it that many times?  ");
           
            while (!int.TryParse(Console.ReadLine(),out userInput))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.\nWhat is the bonus for accomplishing it that many times?    ");                
            }
                base.SetBonusPoints(userInput);
        }
    }

    public override void RecordEvent()
    {
        base.SetNumDone(1);
        if (base.GetNumDone() >= base.GetNumMax())
        {
            base.SetComplete(true);
        }
    }
    
    public override int GetPoints(){
        if (base.GetNumDone() >= base.GetNumMax())
        {
            return base.GetPoints() + base.GetBonus();
        }
        else{
            return base.GetPoints();
        }
    }

    public override string GetXofYSummary()
    {
        return $" -- Currently completed: {base.GetNumDone()}|{base.GetNumMax()}";
    }

    public override string GetCheckBox()
    {
        return base.GetNumDone().ToString();
    }
}