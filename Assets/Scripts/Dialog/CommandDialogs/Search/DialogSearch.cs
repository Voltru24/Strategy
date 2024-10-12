using System.Collections.Generic;
using UnityEngine;

public class DialogSearch : Dialog
{
    public DialogSearch()
    {
        ObjectDialogs = new List<IObjectDialog>
        {
            new MessageDialog("Как дела люди?", new Person("Валера", Color.white))
        };
    }
}
