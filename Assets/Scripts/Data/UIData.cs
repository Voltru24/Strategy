using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIData
{
    private static MapUI _mapUI;
    private static DialogUI _dialogUI;
    public static void SetMapUI(MapUI mapUI)
    {
        _mapUI = mapUI;
    }

    public static bool TryGetMapUI(out MapUI mapUI)
    {
        mapUI = _mapUI;

        return mapUI != null;
    }

    public static void SetDialogUI(DialogUI dialogUI)
    {
        _dialogUI = dialogUI;
    }

    public static bool TryGetDialogUI(out DialogUI dialogUI)
    {
        dialogUI = _dialogUI;

        return dialogUI != null;
    }
}

