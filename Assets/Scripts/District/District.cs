using System;
using System.Collections.Generic;
using UnityEngine;

public class District: MonoBehaviour
{
    [SerializeField] private string _name;
    
    private int _income = 50;
    private List<Command> _commands;

    public IReadOnlyList<Command> Commands => _commands;
    public string Name => _name;
    public int Income => _income;

    private void Start()
    {
        _commands = new List<Command>
        {
            new CommandSearch()
        };
    }

    public void RemoveCommand(Command command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        _commands.Remove(command);
    }
}
