using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ShowDay : MonoBehaviour
{
    [SerializeField] private TurnDays _turnDays;

    private TMP_Text _text;

    private void Awake()
    {
        if (_turnDays == null)
        {
            throw new ArgumentNullException(nameof(_turnDays));
        }

        _text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        Show();
    }

    private void OnEnable()
    {
        _turnDays.ChangedTime += Show;
        _turnDays.ChangedDay += Show;
    }

    private void OnDisable()
    {
        _turnDays.ChangedDay -= Show;
        _turnDays.ChangedTime -= Show;
    }

    private void Show()
    {
        string text = $"Δενό: {_turnDays.CountDay} ";

        if (_turnDays.IsNowNight == false)
        {
            text += "(Δ)";
        }
        else
        {
            text += "(Ν)";
        }

        _text.text = text;
    }
}
