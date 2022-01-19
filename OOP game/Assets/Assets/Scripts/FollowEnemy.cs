using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : EnemyBase
{
    Transform _player;
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;      
    }
    public override void Move() //POLYMORPHISM
    {
        _navMeshAgent.SetDestination(_player.position);
    }
}
