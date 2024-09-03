using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCommand
{
    public Command CompletedCommand { get; private set; }

    public bool IsDeleteCommand { get; private set; }
    
    public ResultCommand(Command command, bool isDeleteCommand)
    {
        CompletedCommand = command;

        IsDeleteCommand = isDeleteCommand;
    }
}

