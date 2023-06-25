public class SimpleGoal : Goal
{

    public SimpleGoal(bool isNew): base(isNew)
    {
        base.SetNumMax(1);
    }

    public override void RecordEvent()
    {
        base.SetComplete(true);
        base.SetNumDone(1);
    }
    
    public override string GetXofYSummary()
    {
        return "";
    }
}