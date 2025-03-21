using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    //private void Awake()
    //{
    //    Actions.OnGameOver += PlayEndSound;
    
    //}

    private void OnTriggerStay(Collider other)
    {
        //if(other.gameObject.CompareTag("Player"))
            Actions.OnPlayerTriggered?.Invoke();
            //Actions.TriggerGameOver();
    }


    //void PlayEndSound()
    //{
    //    print("playing ending sound");
    //}

 
  
}
