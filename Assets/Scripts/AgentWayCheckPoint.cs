using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentWayCheckPoint : MonoBehaviour
{
    //zmienne do wyznacznia kierunków i lista chceck pointów
    [SerializeField] float _switchProbability = 0.2f; 
    [SerializeField] List<PointWay> _chceckPoints;

    //zmienne nav mesh, do której jest przypisany Agent, oraz ile jest punktów, i czy Agent jest w ruchu
    NavMeshAgent _navMeshAgent;
    int _currentWayIndex;
    bool _travelling;
    bool _patrolForward;

    void Start () {
        //pobranie elementu nav mesh, jeśli nav mesh jest nullem zwrócenie inforamcji konsoli,
        //że go brakuje, jeśli nie braukje przejśćie do warunki else, gdzie są przypisaywane checkpointy
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agnet component is not attached to" + gameObject.name);
        }
        else
        {
            if (_chceckPoints != null && _chceckPoints.Count >= 2)
            {
                _currentWayIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("Insufficient patrol points for basic patrolling behaviour.");
            }
        }
    }

    public void Update() //jeśli zaliczony checkpoint w funkcji poniżej to przejście do następnego checkpointa
    {
        if (_travelling && _navMeshAgent.remainingDistance <= 1.0f)
        {
                ChangeWayPoint();
                SetDestination();
        }
    }

    private void ChangeWayPoint()
    {
        //sprawdzenie przy którym, checkpoinice jesteśmy
        if (UnityEngine.Random.Range(0f, 1f) <= _switchProbability)
        {
            _patrolForward = !_patrolForward;
        }

        if (_patrolForward)
        {
            _currentWayIndex = (_currentWayIndex + 1) % _chceckPoints.Count;
        }
    }

    private void SetDestination()
    {
        //ustalenie kierunku dla Agenta jeśli checkpoint nie jest nullem
        if (_chceckPoints!= null)
        {
            Vector3 targetVector = _chceckPoints[_currentWayIndex].transform.position;
            _navMeshAgent.SetDestination(targetVector);
            _travelling = true;
        }

    }


}
