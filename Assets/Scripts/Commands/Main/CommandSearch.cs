using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandSearch : Command
{
    public CommandSearch() 
    { 
        _name = "�����";
    }

    public override void Execute(Action<ResultCommand> takeResult)
    {
        Debug.Log("�� ������ �� �����");

        takeResult?.Invoke(new ResultCommand(this, true));
    }
}
