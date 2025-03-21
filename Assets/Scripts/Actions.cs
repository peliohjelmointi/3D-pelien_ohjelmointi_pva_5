using System;
using UnityEngine;

public static class Actions
{
    public static Action OnEnemyDied;
    public static Action<float> OnPlayerTriggered;

   public static event Action OnGameOver;

    

    public static void TriggerGameOver()
    {
        OnGameOver?.Invoke();
    }
}
