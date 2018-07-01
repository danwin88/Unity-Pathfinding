using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float SpeedTurn = 20f; //ustawnie szybkości obracania
    public float SpeedMove = 5f; //ustawienie szybkości poruszania
   
	void Update ()
	{
        //ustawnienie przyciskó góra, dół na chodzenie, tzn dodanie Vectora3 do przodu lub do tyłu
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward* SpeedMove * Time.deltaTime); 

	    if (Input.GetKey(KeyCode.DownArrow))
	        transform.Translate(-Vector3.forward * SpeedMove * Time.deltaTime);
        //ustawienie przyciskó lewo, prawo na obracanie się
	    if (Input.GetKey(KeyCode.LeftArrow))
	        transform.Rotate(Vector3.up, -SpeedTurn * Time.deltaTime);

	    if (Input.GetKey(KeyCode.RightArrow))
	        transform.Rotate(Vector3.up, SpeedTurn * Time.deltaTime);
    }
}
