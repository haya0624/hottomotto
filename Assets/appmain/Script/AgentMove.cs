using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [SerializeField]
    GameObject destinationObj;

    Vector3 destinationPosition;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        destinationPosition = destinationObj.transform.position;

        GetComponent<NavMeshAgent>().destination = destinationPosition;
    }
}
