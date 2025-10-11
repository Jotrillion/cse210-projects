using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }


    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override void RecordEvent()
    {

        // No state change for eternal goals
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()}  Your points: {GetPoints()})";
    }
    public override string Serialize()
    {
        // Example: EternalGoal|Name|Description|Points
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}