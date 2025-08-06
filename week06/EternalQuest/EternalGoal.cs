// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points) { }

    public override int RecordEvent() => GetPoints();

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return ($"[ ] {GetShortName()} ({GetDescription()})");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}