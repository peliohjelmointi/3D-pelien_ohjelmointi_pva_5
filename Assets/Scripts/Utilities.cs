using UnityEngine;

public static class Utilities
{
    public static void PrintHelloWorld()
    {
        Debug.Log("HELLO WORLD !");
    }

    public static bool isGrounded(Transform transform, Collider collider)
    {
        //mist‰ l‰hetet‰‰n s‰de, mihin suuntaan, kuinka pitk‰lle
        return Physics.Raycast(transform.position, Vector3.down, collider.bounds.extents.y + 0.1f);
    }
}

