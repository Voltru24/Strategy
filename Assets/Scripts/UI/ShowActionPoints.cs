using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowActionPoints : MonoBehaviour
{
    [SerializeField] private ActionPoints _actionPoints;
    [SerializeField] private List<Image> _toggleImages;
    [SerializeField] private Color _colorOn;
    [SerializeField] private Color _colorOff;

    private void Awake()
    {
        if (_actionPoints == null)
        {
            throw new ArgumentNullException(nameof(_actionPoints));
        }

        ShowToggleImages();
        ShowPoints();
    }

    private void OnEnable()
    {
        _actionPoints.ChangeValue += ShowPoints;
        _actionPoints.ChangeMaxValue += ShowToggleImages;
    }

    private void OnDisable()
    {
        _actionPoints.ChangeMaxValue -= ShowToggleImages;
        _actionPoints.ChangeValue -= ShowPoints;
    }

    private void ShowPoints()
    {
        foreach(Image toggleImage in _toggleImages)
        {
            if (toggleImage.gameObject.activeSelf)
            {
                toggleImage.color = _colorOff;
            }
        }

        for (int i = 0; i < _actionPoints.Value; i++)
        {
            _toggleImages[i].color = _colorOn;
        }
    }

    private void ShowToggleImages()
    {
        foreach (Image toggleImage in _toggleImages)
        {
            toggleImage.gameObject.SetActive(false);
        }

        for (int i = 0; i < _actionPoints.MaxValue; i++)
        {
            _toggleImages[i].gameObject.SetActive(true);
        }
    }
}
