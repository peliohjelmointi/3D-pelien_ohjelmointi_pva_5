using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Cube : MonoBehaviour
{
    [SerializeField] Camera cam;
    NavMeshAgent agent;

    public Material defaultMat;
    public Material greenMat;


    void PlayClickSound()
    {
        print("UNIT ACTIVED sound playing..");
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }



    private void Update()
    {
        //Huom. UnityEngine.InputSystem löytyy suoraan Mouse-luokka
        //if (Mouse.current.rightButton.isPressed)                

        if (Input.GetMouseButtonDown(1)) // 1 = oikea hiiren nappi
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //Mouse.current.position.ReadValue(); //jos uusi input system

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Ground")))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

}
