public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
            return _points + _bonus;
        return _points;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() =>
        $"[ {(IsComplete() ? "X" : " ")} ] {_name} ({_description}) -- Completed {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}