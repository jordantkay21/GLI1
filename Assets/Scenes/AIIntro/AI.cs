using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _wayPoints;
    private int _randomTarget;
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        if (_agent == null)
        {
            Debug.LogError("AI did not detect NavMesh Agent");
        }

        _randomTarget = Random.Range(0, _wayPoints.Count);  

        if (_agent != null)
        {
            _agent.destination = _wayPoints[_randomTarget].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
