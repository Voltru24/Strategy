using System;
using UnityEngine;

[RequireComponent(typeof(District))]
public class DistrictTrigger : MonoBehaviour
{
    private District _district;
   
    public event Action<District> OnClickDistrict;

    private void Awake()
    {
        _district = GetComponent<District>();
    }

    public void OnMouseDown()
    {
        OnClickDistrict?.Invoke(_district);
    }
}
