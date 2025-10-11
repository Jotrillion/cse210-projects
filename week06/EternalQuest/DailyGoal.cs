using System;
public class DailyGoal : Goal
{
    private bool _isComplete;
    public DailyGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _isComplete = true;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"DailyGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) Your points: {GetPoints()}";
    }

    public override string Serialize()
    {
        // Example: DailyGoal|Name|Description|Points|TimesCompleted|TargetCompletions|BonusPoints
        return $"DailyGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }


}