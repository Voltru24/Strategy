using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuCommand : MonoBehaviour
{
    [SerializeField] private List<DistrictTrigger> _districtTriggers;
    [SerializeField] private TMP_Text _textName;
    [SerializeField] private Transform _panelForCommand;
    [SerializeField] private List<ButtonCommand> _buttonCommands;
    [SerializeField] private ActionPoints _actionPoints;

    private District _selectedDistrict;

    private void Start()
    {
        ResetInfo();

        foreach (ButtonCommand buttonCommand in _buttonCommands)
        {
            buttonCommand.SetActionPoints(_actionPoints);
        }
    }

    private void OnEnable()
    {
        foreach (DistrictTrigger districtTrigger in _districtTriggers)
        {
            districtTrigger.OnClickDistrict += ShowDistrictInfo;
        }
    }

    private void OnDisable()
    {
        foreach (DistrictTrigger districtTrigger in _districtTriggers)
        {
            districtTrigger.OnClickDistrict -= ShowDistrictInfo;
        }
    }

    private void ProcessResultCommand(ResultCommand resultCommand)
    {
        if (resultCommand.IsDeleteCommand)
        {
            _selectedDistrict.RemoveCommand(resultCommand.CompletedCommand);
        }

        ShowDistrictInfo(_selectedDistrict);
    }

    private void ShowDistrictInfo(District district)
    {
        ResetInfo();

        _textName.text = district.Name;

        _selectedDistrict = district;

        ShowCommands();
    }

    private void ShowCommands()
    {
        for (int i = 0; i < _selectedDistrict.Commands.Count; i++)
        {
            _buttonCommands[i].gameObject.SetActive(true);
            _buttonCommands[i].SetCommand(_selectedDistrict.Commands[i]);
            _buttonCommands[i].TakeResult += ProcessResultCommand;
        }
    }

    private void ResetInfo()
    {
        _textName.text = "";

        foreach (ButtonCommand buttonCommand in _buttonCommands)
        {
            buttonCommand.gameObject.SetActive(false);
        }
    }
}
