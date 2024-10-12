using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog
{
    protected List<IObjectDialog> ObjectDialogs = new List<IObjectDialog>();

    private int _step = 0;

    public void Run()
    {
        if (UIData.TryGetDialogUI(out DialogUI dialogUI))
        {
            dialogUI.ShowUI();

            dialogUI.CompletedMessage += Execute;

            Execute();
        }
    }

    private void Execute()
    {
        if (UIData.TryGetDialogUI(out DialogUI dialogUI))
        {
            if (TryGetObjectDialog(out IObjectDialog objectDialog))
            {
                dialogUI.ShowMessage((MessageDialog)objectDialog);
            }
            else
            {
                dialogUI.CompletedMessage -= Execute;
            }
        }
    }
       

    private bool TryGetObjectDialog(out IObjectDialog objectDialog)
    {
        if(_step == ObjectDialogs.Count)
        {
            objectDialog = null;
            return false;
        }

        objectDialog = ObjectDialogs[_step];
        _step++;

        return true;
    }

}
