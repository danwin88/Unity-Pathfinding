using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //inicjalizacja zmiennych czasowych
    public static int MinuteCount;
    public static int SecondCount;
    public static float MiliCount;
    public static string MiliDisplay;

    //inicjalizacja zmiennych dla czasu, do których są przypisane obiekty canvas
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MiliBox;

	void Update ()
	{
        //wyznaczenie co to jest milisekunda oraz jak ma ją zapisać
	    MiliCount += Time.deltaTime * 10;
	    MiliDisplay = MiliCount.ToString("F0");
	    MiliBox.GetComponent<Text>().text = "" + MiliDisplay;
	    if (MiliCount >= 10)
	    {
            //jeśli warunek się sprawdzi, przeliczenie milisekudny do okienka w lewo
	        MiliCount = 0;
	        SecondCount += 1;
	    }

	    if (SecondCount <= 9)
	    {
	        //jeśli warunek się sprawdzi, przeliczenie sekudny do okienka w lewo
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ",";
	    }
	    else
	    {
            //jeśli nie pozostaje w obecnej postaci
	        SecondBox.GetComponent<Text>().text = "" + SecondCount + ",";
        }

	    if (SecondCount >= 60)
	    {
	        //jeśli warunek się sprawdzi, przeliczenie minuty do okienka w lewo
            SecondCount = 0;
	        MinuteCount +=1;
	    }

	    if (MinuteCount <= 1)
	    {
	        //jeśli warunek się sprawdzi, dodanie minuty w prawe okienko, po liczbą 0
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
	    }
	    else
	    {
            //jeśli warunek się sprawdzi, dodanie minuty w jeśli jest to liczba dwucyfrowa
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
	    }
	}
}
