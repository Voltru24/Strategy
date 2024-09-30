using UnityEngine;

[CreateAssetMenu(fileName = "new Person", menuName = "Person/Create new person",order = 52)]
public class Person : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Color _colorName;
}
