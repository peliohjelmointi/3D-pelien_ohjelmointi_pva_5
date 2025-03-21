using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float health;

    public TextMeshProUGUI healthText;
    //public TMP_Text

    private void Awake()
    {
        Actions.OnPlayerTriggered += TriggerPlayer;
    }

    private void Update()
    {
        healthText.text = health.ToString();
    }

    void TriggerPlayer()
    {
        print("[click] - playing trap sound");
        health--;                     
    }
}
