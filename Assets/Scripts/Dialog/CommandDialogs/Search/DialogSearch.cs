using System.Collections.Generic;
using UnityEngine;

public class DialogSearch : Dialog
{
    public DialogSearch()
    {
        ObjectDialogs = new List<IObjectDialog>
        {
            new MessageDialog("��� ���� ����?", new Person("������", Color.white))
        };
    }
}
