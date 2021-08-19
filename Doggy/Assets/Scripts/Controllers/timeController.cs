using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeController : MonoBehaviour
{
    public float initialTime;                   
    public static float timeRemaining;          
    public static bool timerIsRunning = false;  

    private void Start()
    {
        //verifica la dificultad y voy a ajusto el tiempo inicial
        switch (GameManager.instancia.dificulty)
        {
            //dificultad facil
            case 0:
                initialTime += 10;
                break;
            //dificultad dificil
            case 2:
                initialTime -= 10;
                break;
            //dificultad normal
            default:
                break;

        }
        
        timeRemaining = initialTime;
        
        GameManager.instancia.levelTime = (int)timeRemaining;
        GameManager.instancia.time = (int)timeRemaining;
    }

    void Update()
    {
        
        if (timerIsRunning)
        {
            
            if (GameManager.instancia.time > 0)
            {
                
                
                timeRemaining -= Time.deltaTime;
                GameManager.instancia.time = (int)timeRemaining;
            }
            else
            {
                
                
                
                SceneManager.LoadScene("Death");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    //Al activar, se suman 5 segundos al contador
    public static void ability5sec()
    {
        timeRemaining += 5;
    }
    //Para el tiempo
    public static void stopTime()
    {
        timerIsRunning = false;
    }
    //Continua el tiempo
    public static void continueTime()
    {
        timerIsRunning = true;
    }
}
