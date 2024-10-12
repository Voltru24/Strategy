using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUI : MonoBehaviour
{
    [SerializeField] private GameObject _content;

    private void Awake()
    {
        UIData.SetMapUI(this);
    }

    public void Show(Dialog dialog)
    {
        _content.SetActive(true);
    }

    public void Close()
    {
        _content.SetActive(false);
    }
}
