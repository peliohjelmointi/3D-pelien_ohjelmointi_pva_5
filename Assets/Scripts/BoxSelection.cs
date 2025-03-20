using System;
using UnityEngine;

public class BoxSelection : MonoBehaviour
{
    public Camera cam;

    [SerializeField] Transform enemyTransform;

    [SerializeField] RectTransform boxVisual;

    Rect selectionBox;

    Vector2 startPosition;
    Vector2 endPosition;

    private void Awake()
    {
        startPosition = Vector2.zero;
        endPosition = Vector2.zero;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //ainoastaan klikatulla framella
        {
            startPosition = Input.mousePosition;  //positio pikseleissä
            selectionBox = new Rect(); //luodaan tyhjä suorakulmioinstanssi
        }
        if (Input.GetMouseButton(0)) //niin kauan kuin vas.hiiren nappi pohjassa
        {
            if(boxVisual.rect.width  > 0 || boxVisual.rect.height  > 0)
            {
                //vain jos hiirtä on liikutettu nappi pohjassa (piirretty boxVisualia)
                SelectUnits();
            }

            endPosition = Input.mousePosition;
            DrawVisual();
            DrawSelectionRect();
        }
        if (Input.GetMouseButtonUp(0))
        {
            startPosition = Vector2.zero;
            endPosition = Vector2.zero;
            DrawVisual(); 
        }

    }

    private void DrawVisual()
    {
        // otetaan talteen klikattu positio ja viimeinen positio kun hiiri pohjassa
        Vector2 boxStart = startPosition;
        Vector2 boxEnd = endPosition;

        //lasketaan keskikohta boksille:
        Vector2 boxCenter = (boxStart + boxEnd) / 2;

        // asetetaan boxVisual (rect transform) keskikohdan positioon:
        boxVisual.position = boxCenter;

        //lasketaan boksin koko:
        Vector2 boxSize = new Vector2(Mathf.Abs(boxStart.x - boxEnd.x),
                                     Mathf.Abs(boxStart.y - boxEnd.y));

        //asetetaan koko rect transformille
        boxVisual.sizeDelta = boxSize;
    }

    void DrawSelectionRect()
    {
        if (Input.mousePosition.x < startPosition.x) //hiirtä liikutettu vasemmalle
        {
            selectionBox.xMin = Input.mousePosition.x;
            selectionBox.xMax = startPosition.x;
        }
        else //hiirtä liikutettu oikealle
        {
            selectionBox.xMin = startPosition.x;
            selectionBox.xMax = Input.mousePosition.x;
        }

        if (Input.mousePosition.y < startPosition.y)
        {
            selectionBox.yMin = Input.mousePosition.y;
            selectionBox.yMax = startPosition.y;
        }
        else
        {
            selectionBox.yMin = startPosition.y;
            selectionBox.yMax = Input.mousePosition.y;
        }
    }

    void SelectUnits()
    {

        // TEHTÄVÄ
        //// Lisää haluamasi gameobjectit jonkun skriptin awakessa
        //// listaan allUnitsList.
        //// käy foreachilla läpi jokainen listan gameobjekti,
        //// ja laita if-lause foreachin sisään.  
        //// Esim.

        foreach (var unit in UnitManager.Instance.allUnits)
        {
            if (selectionBox.Contains(cam.WorldToScreenPoint(unit.transform.position)))
            {
                //vaihda vaikka valitun gameobjektin materiaali toiseksi
                print(unit.name);
            }
        }

        //if (selectionBox.Contains(cam.WorldToScreenPoint(enemyTransform.position)))
        //{
        //    print("ENEMY INSIDE SELECTION BOX!");
        //}
    }
}
