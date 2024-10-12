using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class WindowDialog : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMessage;
    [SerializeField] private TMP_Text _textName;

    [SerializeField] private float _speedWrite;


    public void ShowMessage(MessageDialog message, Action completedEvent)
    {
        StartCoroutine(Showing(message, completedEvent));
    }

    private IEnumerator Showing(MessageDialog message, Action completedEvent)
    {
        _textName.text = message.Person.Name;
        _textName.color = message.Person.ColorName;

        _textMessage.text = "";

        WaitForSeconds wait = new WaitForSeconds(_speedWrite);

        foreach (char symbol in message.Text)
        {
            _textMessage.text += symbol;

            yield return wait;
        }

        completedEvent?.Invoke();
    }
}
