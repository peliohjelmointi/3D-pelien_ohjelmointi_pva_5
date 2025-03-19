using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject snowBall = Instantiate(projectilePrefab,
                transform.position,
                transform.rotation); // tai Quaternion.identity;
            Destroy(snowBall, 5f); //tuhotaan 5 sek. kuluttua                                   
        }
    }
 
}
