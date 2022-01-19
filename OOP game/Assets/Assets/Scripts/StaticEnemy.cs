using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : EnemyBase
{
    [SerializeField] List<Transform> _desitinationsList = new List<Transform>();
    int _destinationIndex = 0;
    public override void Move()
    {
        if(transform.position == _navMeshAgent.destination)
        {
            SetNextDestination();
        }
    }

    void SetNextDestination()
    {
        if (_destinationIndex >= _desitinationsList.Count) _destinationIndex = 0;

        _navMeshAgent.SetDestination(_desitinationsList[_destinationIndex].position);
        _destinationIndex++;
    }
}
