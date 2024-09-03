using System;
using Unity.VisualScripting;
using UnityEngine;

public class ActionPoints : MonoBehaviour
{
    [SerializeField] private int _limitMaxValue = 5;
    [SerializeField] private int _maxValue;
    [SerializeField] private int _value;
    [SerializeField] private TurnDays _turnDays;

    public int MaxValue => _maxValue;
    public int Value => _value;

    public event Action ChangeValue;
    public event Action ChangeMaxValue;

    public void Awake()
    {
        if (_turnDays == null)
        {
            throw new ArgumentNullException(nameof(_turnDays));
        }
    }

    private void OnEnable()
    {
        _turnDays.ChangedDay += ResetValue;
        _turnDays.ChangedTime += AddValue;
    }

    private void OnDisable()
    {
        _turnDays.ChangedDay -= ResetValue;
        _turnDays.ChangedTime -= AddValue;
    }

    public void AddMaxValue()
    {
        if (_limitMaxValue > _maxValue)
        {
            _maxValue++;
            ChangeMaxValue?.Invoke();
        }
    }

    public void AddValue()
    {
        if (_maxValue > _value)
        {
            _value++;
            ChangeValue?.Invoke();
        }
    }

    public void ResetValue()
    {
        _value = _maxValue;

        ChangeValue?.Invoke();
    }

    public bool TryTakeValue()
    {
        if (_value > 0)
        {
            _value--;
            ChangeValue?.Invoke();
            return true;
        }

        return false;
    }
}
