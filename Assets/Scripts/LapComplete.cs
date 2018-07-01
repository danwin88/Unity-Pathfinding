using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    //zmienne dla czasu czyli milisekunda, sekunda i minuta
    public int MinuteBestTime;
    public int SecendBestTime;
    public float MilliBestTime;

    //zmienne dla czasu, jako gameobjecty, do których przypisane są potem pola tektstowe w canvasie
    public GameObject MinuteBestDisplay;
    public GameObject SecendBestDispaly;
    public GameObject MiliBestDisplay;

    void OnTriggerEnter()
    {
        //sprawdzeinie po kolzji czy minuta i sekunda równa się zero- mili sekundy nie sprawdza, ze względu na szacunkowy błąd
        if (MinuteBestTime == 0)
        {
            if (SecendBestTime == 0)
            {
                //jeśli warunnki powyżej okaża się prawdziwe, przypisanie tym zmiennym czasu obecnego po kolizji
                MinuteBestTime = Timer.MinuteCount;
                SecendBestTime = Timer.SecondCount;
                MilliBestTime = Timer.MiliCount;
            }
        }
       
        if (MinuteBestTime >= Timer.MinuteCount)
        {
            //sprawdzenie, czy najlepszy czas do tej pory jest gorszy od obecnego
            if (SecendBestTime >= Timer.SecondCount)
            {
                if (MilliBestTime >= Timer.MiliCount)
                {
                    //jeśli warunki okażą się prawdziwe, to przypisnaie polom canvas obecnego czasu
                    if (Timer.SecondCount <= 9)
                    {
                        SecendBestDispaly.GetComponent<Text>().text = "0" + Timer.SecondCount + ",";
                    }
                    else
                    {
                        SecendBestDispaly.GetComponent<Text>().text = "" + Timer.SecondCount + ",";
                    }

                    if (Timer.MinuteCount <= 9)
                    {
                        MinuteBestDisplay.GetComponent<Text>().text = "0" + Timer.MinuteCount + ":";
                    }
                    else
                    {
                        MinuteBestDisplay.GetComponent<Text>().text = "" + Timer.MinuteCount + ":";
                    }

                    MiliBestDisplay.GetComponent<Text>().text = "" + Timer.MiliCount;
                }
            }
        }
        //wyzerowanie obecnego czasu, po kolizji
        Timer.MinuteCount = 0;
        Timer.SecondCount = 0;
        Timer.MiliCount = 0;
    }
}