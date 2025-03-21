using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void Awake()
    {
        //Actions.OnGameOver += PlayEndSound;
    }

    private void OnTriggerStay(Collider other)
    {
        //if(other.gameObject.CompareTag("Player"))
        Actions.OnPlayerTriggered?.Invoke(0.1f);

        //event actionin invoke ei onnistu muualta, kuin
        // vain siinä skriptissä, jossa se on esitelty

        //Actions.OnGameOver?.Invoke(); //aiheuttaa virheen

        Actions.TriggerGameOver();
    }

    private void OnMouseDown()
    {
        
    }

    public void PlayEndSound()
    {
        print("playing ending sound");
    }



}
