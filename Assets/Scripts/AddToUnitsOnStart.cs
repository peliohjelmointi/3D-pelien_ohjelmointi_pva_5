using UnityEngine;

public class AddToUnitsOnStart : MonoBehaviour
{

    void Start()
    {
        UnitManager.Instance.allUnits.Add(gameObject);
    }


}
