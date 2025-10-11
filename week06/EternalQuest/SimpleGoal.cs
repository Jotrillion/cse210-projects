using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }



    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()})  Your points: {GetPoints()}";
    }
    public override string Serialize()
    {
        // Example: SimpleGoal|Name|Description|Points|IsComplete
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}