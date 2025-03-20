using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;

    NavMeshAgent agent;

 
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();       
    }

    private void Start()
    {
        UnitManager.Instance.allUnits.Add(gameObject);
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }



}
