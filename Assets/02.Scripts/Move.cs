using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public NavMeshAgent player;
    private Vector3 pointVecter;
    private bool run = false;

    private void Start()
    {
        player = player.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                player.destination = hit.point;
                run = true;
                pointVecter = hit.point;
            }
        }

        if (run)
        {
            float distance = Vector3.Distance(player.transform.position, pointVecter);
            Debug.Log("Distance : " + distance);

            if (distance < 1.5f)
            {
                Debug.Log("Stop");
                run = false;
            }
        }

    }
}
