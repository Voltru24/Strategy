using System;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [SerializeField] private int _value;

    public int Value => _value;

    public event Action ChangedValue;

    public void AddValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }

        _value += value;

        ChangedValue?.Invoke();
    }

    public bool TryTakeValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }

        if (_value >= value)
        {
            _value -= value;

            ChangedValue?.Invoke();

            return true;
        }

        return false;
    }
}
