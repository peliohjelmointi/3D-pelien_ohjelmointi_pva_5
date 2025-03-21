using UnityEngine;
using UnityEngine.Rendering;

public class RangeIndicator : MonoBehaviour
{
    [SerializeField] float range = 5f;

    Transform rangeIndicator;

    [SerializeField] Material defaultMaterial;
    [SerializeField] Material RedMaterial;

    [SerializeField] GameObject obstacle;

    private void Awake()
    {
        rangeIndicator = transform.Find("RangeIndicator");
        rangeIndicator.GetComponent<Renderer>().material = defaultMaterial;

        Actions.OnEnemyDied += ChangeColorToRed;
    }

    private void Update()
    {
        //jos objektilla ei ole parentia, niin 'world' on parent
        rangeIndicator.localScale = new Vector3(range, rangeIndicator.localScale.y, range);

        //Lasketaan matka pelaajasta obstacleen. Jos matka < range,
        //vaihdetaan obstaclen materiaali punaiseksi. Jos taas, ei, asetaan vihreäksi
        
        if(Vector3.Distance(transform.position,obstacle.transform.position) < range)
        {
            obstacle.GetComponent<Renderer>().material = RedMaterial;
        }
        else
        {
            obstacle.GetComponent<Renderer>().material = defaultMaterial;
        }


    }

    public void ChangeColorToRed()
    {
        //print("Change color to red");
        transform.GetComponent<Renderer>().material = RedMaterial;
    }

}
