public class EternalGoal: Goal{

    public EternalGoal(bool isNew):base(isNew)
    {
        base.SetNumMax(-1);
    }
    
    public override void RecordEvent(){
        base.SetNumDone(1);
    }

    public override string GetXofYSummary()
    {
        return "";
    }

    public override string GetCheckBox()
    {
        return "\u221E";
    }
}