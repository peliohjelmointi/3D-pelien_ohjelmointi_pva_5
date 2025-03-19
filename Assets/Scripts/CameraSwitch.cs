using System;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera[] cameras;

    int currentCameraIndex = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchToNextCamera();
        }
    }

    private void SwitchToNextCamera()
    {
        // disabloidaan nykyinen kamera
        cameras[currentCameraIndex].gameObject.SetActive(false);
        // lis‰t‰‰n indeksi‰ yhdell‰, jos viimeisess‰, palataan alkuun
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
        // enabloidaan uusi kamera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}
