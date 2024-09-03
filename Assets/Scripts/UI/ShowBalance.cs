using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ShowBalance : MonoBehaviour
{
    [SerializeField] private Balance _balance;

    private TMP_Text _text;

    private void Awake()
    {
        if (_balance == null)
        {
            throw new ArgumentNullException(nameof(_balance));
        }

        _text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        Show();
    }

    private void OnEnable()
    {
        _balance.ChangedValue += Show;
    }

    private void OnDisable()
    {
        _balance.ChangedValue -= Show;
    }

    private void Show()
    {
        _text.text = _balance.Value.ToString();
    }
}
