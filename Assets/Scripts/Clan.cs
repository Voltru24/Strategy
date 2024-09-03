using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Clan 
{
    private const int MinLengthName = 3;
    private const int MaxLengthName = 25;

    [SerializeField] private string _name;
    [SerializeField] private List<District> _districts = new List<District>();

    public IReadOnlyList<District> Districts => _districts;
    public string Name => _name;

    public Clan(string name) 
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (name.Length < MinLengthName || name.Length > MaxLengthName)
        {
            throw new ArgumentOutOfRangeException(nameof(name));
        }

        _name = name;
    }   

    public void AddDistrict(District district)
    {
        if (district == null)
        {
            throw new ArgumentNullException(nameof(district));
        }

        if (_districts.Contains(district))
        {
            throw new InvalidOperationException("There is already such an district in this clan!");
        }

        _districts.Add(district);
    }
}

