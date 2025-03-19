using System;
using UnityEngine;

public class RefExample : MonoBehaviour
{
    int num1 = 10;
    int num2 = 10;

    private void Start()
    {
        IncreaseValueByValue(num1); //default
        Debug.Log("num 1 after increase by value" + num1.ToString());

        IncreaseValueByReference(ref num2);
        Debug.Log("num 2 after increase by reference" + num2.ToString());
    }
    private void IncreaseValueByValue(int num)
    {
        num += 10; //rivillä 6 oleva arvo ei muutu, ainoastaan tämän funktion sisällä arvo muuttuu

    }
    private void IncreaseValueByReference(ref int num)
    {
        num += 10; // muuttaa annetun muuttujan arvoa!
    }

   
}
