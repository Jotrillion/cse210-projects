using System;
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, string points, int targetCount, int bonusPoints, int currentCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Currently completed: {_currentCount}/{_targetCount}  Your points: {GetPoints()} Bonus Points: {_bonusPoints}";
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override string Serialize()
    {
        // Example: ChecklistGoal|Name|Description|Points|CurrentCount|TargetCount|BonusPoints
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }
}