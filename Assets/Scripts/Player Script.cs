using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScript : MonoBehaviour
{
    public float health;

    public TextMeshProUGUI healthText;
    //public TMP_Text

    delegate void MyFunction();
    MyFunction printtaa;

    public UnityEvent onPlayerDeath; //voidaan editorista
                        //m‰‰ritt‰‰, mitk‰ funktiot ajetaan
                        // kun health < 0
    

    void PrintHello()
    {
        print("HELLO");
    }

    void PrintWorld()
    {
        print("WORLD");
    }


    private void Awake()
    {
        Actions.OnPlayerTriggered += TriggerPlayer;
        //printtaa = PrintHello;
        //printtaa();
    }

    private void Update()
    {
        healthText.text = health.ToString();
    }

    void TriggerPlayer(float damage)
    {
        print("[click] - playing trap sound");
        health-= damage;
        
        if(health < 0)
        {
            onPlayerDeath?.Invoke(); //kaikki editorissa asetetut
                                //metodit ajetaan
        }
        //printtaa = PrintWorld;
        //printtaa();
    }

    public void FadeScreenToBlack()
    {
        print("screen starting to fade...");
    }
}
