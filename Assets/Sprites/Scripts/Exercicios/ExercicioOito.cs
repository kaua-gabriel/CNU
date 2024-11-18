using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
    private int hora = 0;
    private int dias = 0;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 10f)
        {
            hora++;
            timer = 0f;

            if (hora >= 24)
            {
                hora = 0;
                dias++;
                Debug.Log("Dias passados: " + dias);
            }
        }
    }
}

