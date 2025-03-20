using System.Collections.Generic; //List vaatii tämän
using Unity.VisualScripting;
using UnityEngine;


public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance;

    public List<GameObject> allUnits = new List<GameObject>();
    public List<GameObject> selectedUnits = new List<GameObject>();

    [SerializeField] Camera cam;

    private void Awake()
    {
        if(Instance!= null && Instance!= this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Selectable")))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    MultiSelect(hit.collider.gameObject);
                }
                else //klikataan normaalisti yhtä gameobjektia
                {
                    SelectOneUnit(hit.collider.gameObject);
                }
            }
            else // ei osuttu Selectable-layeriin
            {
                DeselectAllUnits();
            }
        }
    }

   void SelectOneUnit(GameObject unit)
    {
        DeselectAllUnits();
        selectedUnits.Add(unit);
        ToggleUnit(unit, true);
    }

    void DeselectAllUnits()
    {
        foreach (var unit in selectedUnits)
        {
            ToggleUnit(unit, false);
            unit.GetComponent<Renderer>().material = unit.GetComponent<Cube>().defaultMat;
        }
        selectedUnits.Clear();

    }

    void MultiSelect(GameObject unit)
    {
        if (selectedUnits.Contains(unit) == false)
        {
            selectedUnits.Add(unit);
            ToggleUnit(unit, true);
        }
        else //löytyy jo valittujen listalta
        {
            ToggleUnit(unit, false);
            selectedUnits.Remove(unit);
        }
    }

    void ToggleUnit(GameObject unit, bool isActive)
    {
        unit.GetComponent<Cube>().enabled = isActive;
        
        if(isActive==true)
            unit.GetComponent<Renderer>().material = unit.GetComponent<Cube>().greenMat;
        else
            unit.GetComponent<Renderer>().material = unit.GetComponent<Cube>().defaultMat;
    }


}
