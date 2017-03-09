using UnityEngine;
using System.Collections;

public class NavMeshEnemy : MonoBehaviour {

    public Transform player;
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = player.position;
	}
}
