using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;

    NavMeshAgent agent;
 
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        Actions.OnEnemyDied += PlayDeathSound;
    }

    private void Start()
    {
        UnitManager.Instance.allUnits.Add(gameObject);
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            Actions.OnEnemyDied?.Invoke();
        }
    }

    void PlayDeathSound()
    {
        print("AAARRRGH");
        Destroy(gameObject);
    }

}
