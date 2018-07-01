using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTrigger : MonoBehaviour {

    public Collider FinishCollider; //publiczny collider przypisnay do początkowego/ostatniego punktu na trasie

    void Start()
    {
        FinishCollider = GetComponent<Collider>(); //pobranie tego komponentu
    }
    void OnTriggerEnter()
    {
        FinishCollider.isTrigger = false; //wyłączenie triggera i collidera po kolizji z tym colliderem
        FinishCollider.enabled = !FinishCollider.enabled;
    }
   
}
