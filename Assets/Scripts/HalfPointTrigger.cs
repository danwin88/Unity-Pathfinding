using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Animations;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public Collider _finishCollider; //kolidder, do której jest przypisany punkt początkowy/ ostatni 
    void OnTriggerEnter()
    {
        //funkcja po kontakcie z punktem w połowie trasy, która włącza trigger i collider w ostatnim punkcie 
        _finishCollider.enabled = true;
        _finishCollider.isTrigger = true;
    }
}
