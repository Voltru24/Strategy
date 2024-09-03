using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonNextTurn : MonoBehaviour
{
    [SerializeField] private TurnDays _turnDays;

    private void Awake()
    {
        if (_turnDays == null)
        {
            throw new ArgumentNullException(nameof(_turnDays));
        }
    }

    public void OnClick()
    {
        _turnDays.Next();
    }
}
