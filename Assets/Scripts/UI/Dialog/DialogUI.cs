using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogUI : MonoBehaviour
{
    [SerializeField] private GameObject _content;
    [SerializeField] private WindowDialog _windowDialog;

    public event Action CompletedMessage;

    private void Awake()
    {
        UIData.SetDialogUI(this);
    }

    public void ShowUI()
    {
        if (UIData.TryGetMapUI(out MapUI mapUI))
        {
            mapUI.Close();
        }

        _content.SetActive(true);
    }

    public void ShowMessage(MessageDialog messageDialog)
    {
        _windowDialog.ShowMessage(messageDialog, CompletedMessage);
    }

    public void CloseUI()
    {
        _content.SetActive(false);
    }
    
}
