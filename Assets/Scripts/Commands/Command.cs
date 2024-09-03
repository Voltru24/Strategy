using System;

public abstract class Command
{
    protected string _name;

    public string Name => _name;

    public abstract void Execute(Action<ResultCommand> takeResult);
}
