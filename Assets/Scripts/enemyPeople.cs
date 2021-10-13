using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyPeople : MonoBehaviour
{
    public Player player;
    public Transform dulo;
    public NavMeshAgent _agent;
    public Transform[] wyapoints;
    public int wyapointid;
    private void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
        _agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        _agent.SetDestination(wyapoints[0].position);
    }

    void Update()
    {
        if (_agent.remainingDistance < _agent.stoppingDistance)
        {
            wyapointid = (wyapointid + 1) % wyapoints.Length;
            _agent.SetDestination(wyapoints[wyapointid].position);
        }
        Vector3 direction = player.transform.position - dulo.position;
        Vector3 forwardDirection = new Vector3(direction.x, 0, direction.z);
        dulo.rotation = Quaternion.LookRotation(forwardDirection);
    }

}
