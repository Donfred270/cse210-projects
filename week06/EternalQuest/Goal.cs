// Goal.cs
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public bool IsComplete() => _isComplete;
    public virtual string GetName() => _name;
}