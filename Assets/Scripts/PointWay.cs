using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointWay : MonoBehaviour
{
    //Stworzenie Gizmosów, tych czerwonych kulek, które potem są przypisane do punktów
    [SerializeField] protected float DebugDrawRadius = 1.0f;
    public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, DebugDrawRadius);
    }
}
