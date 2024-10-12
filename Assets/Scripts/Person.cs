using UnityEngine;

public class Person 
{
    [SerializeField] private string _name;
    [SerializeField] private Color _colorName;

    public Person(string name, Color colorName)
    {
        _name = name;
        _colorName = colorName;
    }

    public string Name => _name;
    public Color ColorName => _colorName;
}
