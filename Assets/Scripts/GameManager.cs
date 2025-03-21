using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameObject pausePanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
          
        }
    }
}
