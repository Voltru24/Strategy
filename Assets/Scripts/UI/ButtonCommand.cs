using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonCommand : MonoBehaviour
{
    [SerializeField] private TMP_Text _textNameCommand;

    private Command _command;
    private ActionPoints _actionPoints;
  
    public event Action<ResultCommand> TakeResult;

    public void OnClick()
    {
        if (_command == null)
        {
            throw new ArgumentNullException(nameof(_command));
        }

        if (_actionPoints == null)
        {
            throw new ArgumentNullException(nameof(_actionPoints));
        }

        if (_actionPoints.TryTakeValue())
        {
            _command.Execute(TakeResult);
        }
        else
        {
            Debug.Log("Нету очков действия!");
        }
    }

    public void SetCommand(Command command)
    {
        if(command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        if (_textNameCommand == null)
        {
            throw new ArgumentNullException(nameof(_textNameCommand));
        }

        _command = command;
        _textNameCommand.text = command.Name;
    }

    public void SetActionPoints(ActionPoints actionPoints)
    {
        _actionPoints = actionPoints;
    }
}
