using UnityEngine;

public class Distances : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;

    private void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 obstaclePosition = obstacle.transform.position;

        //float distance = Vector3.Distance(playerPosition, obstaclePosition);
        //print(distance);

        //sama kuin:
        Vector3 distanceVector = playerPosition - obstaclePosition;
        float distance = distanceVector.magnitude;
               
        print(distance);
       

    }
}
