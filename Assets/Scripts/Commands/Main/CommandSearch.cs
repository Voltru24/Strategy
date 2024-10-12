using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandSearch : Command
{
    public CommandSearch() 
    {
        _name = "Поиск";
    }

    public override void Execute(Action<ResultCommand> takeResult)
    {
        new DialogSearch().Run();

        takeResult?.Invoke(new ResultCommand(this, true));
    }
}
