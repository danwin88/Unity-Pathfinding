using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenager : MonoBehaviour
{
    public static bool IsPaused = false; //zmienna true/ false badająca czy gra jest zatrzymana czy nie
    public void Resume()
    {
        Time.timeScale = 1; //przywrócenie czasu
        IsPaused = false;   //brak pauzy
    }
    public void Pause()
    {
        Time.timeScale = 0; //zatrzymanie czas
        IsPaused = true;   //pauza włączona
    }
    public void Stop()
    {
        Time.timeScale = 0; //zatrzymanie czasu
        SceneManager.LoadScene("SampleScene"); //załadowanie nowej sceny
    }
}
