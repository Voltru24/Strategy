using System;
using UnityEngine;

public class TurnDays : MonoBehaviour
{
    [SerializeField] private int _countDay = 1;
    
    [SerializeField] private bool _isNowNight = false;

    public int CountDay => _countDay;
    public bool IsNowNight => _isNowNight;

    public event Action ChangedTime;
    public event Action ChangedDay;

    public void Next()
    {
        if (_isNowNight == true)
        {
            _countDay++;
            _isNowNight = false;
            ChangedDay?.Invoke();
        }
        else
        {
            _isNowNight = true;
            ChangedTime?.Invoke();
        }   
    }
}
