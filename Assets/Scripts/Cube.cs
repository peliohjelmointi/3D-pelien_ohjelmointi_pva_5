using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        UnitManager.Instance.allUnits.Add(gameObject);        
    }

  
}
