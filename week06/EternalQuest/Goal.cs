using System;
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return  _points;
    }


    public void SetPoints(string points)
    {
        _points = points;
    }

    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    public abstract string Serialize();
}