using UnityEngine;

public class ScreenPosition : MonoBehaviour
{
    public Camera cam;

    private void Start()
    {
        Vector2 screenPoint = cam.WorldToScreenPoint(transform.position);
        print("SCREEN POINT=" + screenPoint.ToString());
    }

}
