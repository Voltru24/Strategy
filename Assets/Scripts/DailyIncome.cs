using UnityEngine;

public class DailyIncome : MonoBehaviour
{
    [SerializeField] private TurnDays _turnDays;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _turnDays.ChangedDay += GiveIncome;
    }

    private void OnDisable()
    {
        _turnDays.ChangedDay -= GiveIncome;
    }

    private void GiveIncome()
    {
        Debug.Log(_player.Clan.Districts.Count);

        foreach (District district in _player.Clan.Districts)
        {
            _player.Balance.AddValue(district.Income);
        }
    }
}
