using UnityEngine;

[RequireComponent(typeof(Balance))]
public class Player : MonoBehaviour
{
    private Balance _balance;
    [SerializeField]private Clan _clan;

    public Clan @Clan => _clan;
    public Balance @Balance => _balance;

    private void Awake()
    {
        _balance = GetComponent<Balance>();
    }
}
